﻿namespace QLearning.Core.Agent
{
    using System;
    using System.Collections.Generic;
    using Environment;

    public interface IQAgent<TEnvironment> : IAgent<TEnvironment>
        where TEnvironment : IRLEnvironment
    {
        TEnvironment Environment { get; set; }
        /// <summary>
        /// Gets or Sets the Discount Rate, or Discount Factor, used in the Q-Learning formula (aka gamma)
        /// </summary>
        double DiscountRate { get; set; }
        /// <summary>
        /// Gets or Sets the Learning Rate used in the Q-Learning formula (aka alpha)
        /// </summary>
        double LearningRate { get; set; }
        /// <summary>
        /// Gets or Sets the episode in which epsilon (greedy strategy) decay will start.  Also used when calculating epsilon's decay value
        /// </summary>
        double EpsilonDecayStart { get; set; }
        /// <summary>
        /// Gets or Sets the the episode in which epsilon (greedy strategy) decay will end.  Also used when calculating epsilon's decay value
        /// </summary>
        double EpsilonDecayEnd { get; set; }
        int MaximumAllowedMoves { get; set; }
        int MaximumAllowedBacktracks { get; set; }
        /// <summary>
        /// Gets or Sets the number of training episodes utilized to build the Quality table
        /// </summary>
        int NumberOfTrainingEpisodes { get; set; }
        /// <summary>
        /// Gets or sets a list of stored successful training episodes
        /// </summary>
        List<TrainingSession> TrainingEpisodes { get; set; }
        /// <summary>
        /// Gets the best session from a training set, based on total score
        /// </summary>
        TrainingSession BestTrainingSession { get; }

        int State { get; set; }
        int Moves { get; set; }
        double Score { get; set; }

        void Train();
        void Train(bool overrideBaseEvents);
        /// <summary>
        /// Runs the agent through the environment utilizing the Q-Table policies for the best action(s) to take from a given state
        /// </summary>
        void Run(int fromState);
        /// <summary>
        /// Runs the agent through the environment utilizing the Q-Table policies for the best action(s) to take from a given state
        /// </summary>
        /// <param name="fromState">The state from which the agent will start</param>
        /// <param name="overrideBaseEvents">Boolean value that determines whether to override events in this base class</param>
        void Run(int fromState, bool overrideBaseEvents);
    }
}