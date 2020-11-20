﻿namespace QLearningMaze.Core.Mazes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using QLearning.Core;
    using Mazes;
    using System.Linq;

    public partial class MazeBaseNew : QLearningMutliObjectiveBase, IMazeNew
    {
        public MazeBaseNew() 
        {
            SetupStandardValues();
        }

        public MazeBaseNew(
            int columns, 
            int rows, 
            int startPosition,
            int goalPosition, 
            double discountRate,
            double learningRate)
            : base((columns * rows), Enum.GetNames(typeof(Actions)).Length)
        {
            Columns = columns;
            Rows = rows;
            StatesPerPhase = columns * rows;
            StartPosition = startPosition;
            GoalPosition = goalPosition;
            LearningRate = learningRate;
            DiscountRate = discountRate;
            SetupStandardValues();
        }

        private void SetupStandardValues()
        {
            MaximumAllowedBacktracks = 3; 
            _numberOfActions = Enum.GetNames(typeof(Actions)).Length;
            ObjectiveAction = (int)Actions.CompleteRun;
            GetRewardAction = (int)Actions.GetCustomReward;
        }

        public int Columns { get; set; }
        public int Rows { get; set; }
        public int StartPosition { get; set; }

        private int _goalPosition;

        public int GoalPosition
        {
            get { return _goalPosition; }
            set 
            {
                if (value != _goalPosition)
                {
                    _goalPosition = value;

                    ObjectiveStates.Clear();
                    ObjectiveStates.Add(_goalPosition);
                }
            }
        }

        public double MovementPunishement { get; set; } = -1;
        public List<MazeObstruction> Obstructions { get; set; } = new List<MazeObstruction>();

        public override void InitializeStatesTable()
        {
            if (AdditionalRewards == null)
                AdditionalRewards = new List<CustomObjective>();

            
            _numberOfStates = Rows * Columns * GetCustomRewardPhaseAdjustment();
            base.InitializeStatesTable();
            ObjectiveAction = (int)Actions.CompleteRun;

            for (int state = 0; state < NumberOfStates; ++state)
            {
                int position = GetPosition(state);

                if (position >= Columns) StatesTable[state][(int)Actions.MoveUp] = state - Columns;
                if (position % Columns != 0 && position > 0) StatesTable[state][(int)Actions.MoveLeft] = state - 1;
                if (position < StatesPerPhase - 1 && (position + 1) % Columns != 0) StatesTable[state][(int)Actions.MoveRight] = state + 1;
                if (position < StatesPerPhase - Columns) StatesTable[state][(int)Actions.MoveDown] = state + Columns;

                if (position == GoalPosition)
                {
                    StatesTable[state][(int)Actions.CompleteRun] = state;
                    StatesTable[state][(int)Actions.MoveDown] = -1;
                    StatesTable[state][(int)Actions.MoveLeft] = -1;
                    StatesTable[state][(int)Actions.MoveRight] = -1;
                    StatesTable[state][(int)Actions.MoveUp] = -1;
                }
            }

            SetObstructions();
        }

        protected virtual int GetCustomRewardPhaseAdjustment()
        {
            return (AdditionalRewards.Where(v => v.Value > 0).Count() + 1);
        }

        public override void InitializeRewardsTable()
        {
            if (RewardsTable == null ||
                RewardsTable.Length < NumberOfStates)
            {
                RewardsTable = new double[NumberOfStates][];
            }

            // Create an initial rewards table for each possible state/action using -1 as the movement cost
            for (int i = 0; i < RewardsTable.Length; ++i)
            {
                if (RewardsTable[i] == null ||
                    RewardsTable[i].Length != Enum.GetNames(typeof(Actions)).Length)
                {
                    RewardsTable[i] = new double[Enum.GetNames(typeof(Actions)).Length];
                }

                for (int j = 0; j < RewardsTable[i].Length; ++j)
                {
                    RewardsTable[i][j] = -1;
                }
            }


            PrioritizeFromState = StartPosition;

            // Use the base rewards assignment
            base.InitializeRewardsTable();

            int goalToEnd = StatesPerPhase - (GoalPosition % StatesPerPhase);
            int finalGoalRewardState = NumberOfStates - goalToEnd;
            RewardsTable[finalGoalRewardState][(int)Actions.CompleteRun] = ObjectiveReward;
        }

        protected virtual int GetPosition(int state)
        {
            return state % StatesPerPhase;
        }

        public virtual void AddObstruction(int betweenState, int andState)
        {
            if (StatesTable == null)
                InitializeStatesTable();

            var exists = Obstructions.Where(o => (o.BetweenSpace == betweenState && o.AndSpace == andState) ||
                (o.AndSpace == betweenState && o.BetweenSpace == andState));

            if (exists == null)
                return;

            var obstruction = new MazeObstruction
            {
                BetweenSpace = betweenState,
                AndSpace = andState
            };

            Obstructions.Add(obstruction);
            SetObstruction(obstruction);
        }

        protected virtual void SetObstructions()
        {
            foreach (var obstruction in Obstructions)
            {
                SetObstruction(obstruction);
            }
        }

        protected virtual void SetObstruction(MazeObstruction obstruction)
        {
            var betweenAction = GetActionBetweenStates(obstruction.BetweenSpace, obstruction.AndSpace);
            var andAction = GetActionBetweenStates(obstruction.AndSpace, obstruction.BetweenSpace);
            var phase = 0;

            while (obstruction.BetweenSpace + phase <= NumberOfStates)
            {
                StatesTable[obstruction.BetweenSpace + phase][(int)betweenAction] = -1;
                StatesTable[obstruction.AndSpace + phase][(int)andAction] = -1;
                phase += StatesPerPhase;
            }
        }

        public virtual void RemoveObstruction(int betweenState, int andState)
        {
            if (StatesTable == null)
                InitializeStatesTable();

            var obstruction = Obstructions.Where(o => (o.BetweenSpace == betweenState && o.AndSpace == andState) ||
                (o.AndSpace == betweenState && o.BetweenSpace == andState)).FirstOrDefault();

            if (obstruction == null)
                return;

            Obstructions.Remove(obstruction);

            int betweenAction = (int)GetActionBetweenStates(betweenState, andState);
            int andAction = (int)GetActionBetweenStates(andState, betweenState);

            StatesTable[betweenState][betweenAction] = andState;
            StatesTable[andState][andAction] = betweenState;
        }

        protected virtual Actions GetActionBetweenStates(int betweenState, int andState)
        {
            int differential = betweenState - andState;

            if (differential == Columns) return Actions.MoveUp;
            if (differential == -Columns) return Actions.MoveDown;
            if (differential == 1) return Actions.MoveLeft;
            if (differential == -1) return Actions.MoveRight;
            if (differential == StatesPerPhase) return Actions.GetCustomReward;

            return Actions.CompleteRun;

        }

        public virtual void AddReward(CustomObjective reward)
        {
            var r = AdditionalRewards.Where(s => s.State == reward.State).FirstOrDefault();

            if (r != null)
                return;

            AdditionalRewards.Add(reward);
        }

        public virtual void AddReward(int state, double reward)
        {
            AddReward(new CustomObjective { State = state, Value = reward });
        }

        public virtual void RemoveReward(int state)
        {
            var reward = AdditionalRewards.Where(s => s.State == state).FirstOrDefault();

            if (reward != null)
                AdditionalRewards.Remove(reward);
        }

        public List<CustomObjective> GetAdditionalRewards()
        {
            return AdditionalRewards;
        }
    }
}