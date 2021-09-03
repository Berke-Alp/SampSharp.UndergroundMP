namespace SampSharp.UndergroundMP.Events
{
    public class AddModelEventArgs
    {
        /// <summary>
        /// The name of the model which has been set up for a player.
        /// </summary>
        public string ModelName { get; set; }
        /// <summary>
        /// The model ID assigned to the model for the player.
        /// </summary>
        public int ModelID { get; set; }
    }
}
