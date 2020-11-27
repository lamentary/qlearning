namespace QLearning.Core.Environment
{
    using System.Collections.Generic;

    public interface ITDEnvironmentMultiObjective : ITDEnvironment
    {
        /// <summary>
        /// Gets or Sets a list of custom rewards
        /// </summary>
        List<CustomObjective> AdditionalRewards { get; set; }
    }
}