﻿namespace QLearning.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class QLearningMutliObjectiveBase : QLearningBase, IQLearningMultiObjective
    {
        public virtual int GetRewardAction { get; set; } = -1;
        public virtual int PrioritizeFromState { get; set; }
        
        public QLearningMutliObjectiveBase() { }

        public QLearningMutliObjectiveBase(int numberOfStates, int numberOfActions)
            : base(numberOfStates, numberOfActions)
        {
        }

        public QLearningMutliObjectiveBase(
            int numberOfStates,
            int numberOfActions,
            double learningRate,
            double discountRate,
            string qualitySaveDirectory,
            double objectiveReward,
            int objectiveAction,
            List<int> objectiveStates,
            int maximumAllowedMoves = 1000,
            int maximumAllowedBacktracks = -1)
            : base(
                  numberOfActions,
                  numberOfStates,
                  learningRate,
                  discountRate,
                  qualitySaveDirectory,
                  objectiveReward,
                  objectiveAction,
                  objectiveStates,
                  maximumAllowedMoves,
                  maximumAllowedBacktracks)
        {
            
        }

        public List<CustomObjective> AdditionalRewards { get; set; } = new List<CustomObjective>();

        private void SetPhaseSize()
        {
            if (StatesPerPhase <= 0)
            {
                StatesPerPhase = StatesTable.Length;
            }
        }

        public override void InitializeRewardsTable(int numberOfStates, int numberOfActions)
        {
            SetPhaseSize();
            base.InitializeRewardsTable(numberOfStates, numberOfActions);
            SetCustomObjectives();
        }

        public override void InitializeRewardsTable()
        {
            SetPhaseSize();
            base.InitializeRewardsTable();
            SetCustomObjectives();
        }

        public virtual void SetCustomObjectives()
        {
            var prioritizedObjectives = AdditionalRewards.OrderByDescending((priority) =>
                {
                    int differential = (priority.State > PrioritizeFromState ? priority.State - PrioritizeFromState : PrioritizeFromState - priority.State);
                    var value = (differential * -1) + priority.Value; // Hardcoded movement of -1 - look into more flexible approach

                    return value;
                });

            SetCustomObjectives(prioritizedObjectives);
        }

        public virtual void SetCustomObjectives(IOrderedEnumerable<CustomObjective> prioritizedObjectives)
        {
            int rewardPriority = 0;
            SetPhaseSize();

            foreach(var objective in prioritizedObjectives)
            {
                if (objective.IsMultiphase ||
                    objective.Value < 0)
                {
                    SetMultiPhaseObjective(objective);
                }
                else
                {
                    SetObjectiveActionNextState(objective.State + rewardPriority);
                    RewardsTable[objective.State + rewardPriority][GetRewardAction] = objective.Value;
                    rewardPriority += StatesPerPhase;
                }
            }
        }

        protected virtual void SetMultiPhaseObjective(CustomObjective objective)
        {

            int phase = objective.State;

            while (phase < StatesTable.Length)
            {
                for (int i = 0; i < _numberOfActions; ++i)
                {
                    RewardsTable[phase][i] = objective.Value;
                }

                phase += StatesPerPhase;
            }
        }

        protected virtual void SetObjectiveActionNextState(int state)
        {
            for (int i = 0; i < _numberOfActions; ++i)
            {
                StatesTable[state][i] = -1;
            }

            if (state + (StatesPerPhase) <= StatesTable.Length - 1)
            {
                StatesTable[state][GetRewardAction] = state + StatesPerPhase;
            }
        }
    }
}