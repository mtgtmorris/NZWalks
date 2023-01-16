﻿namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionID { get; set; }
        public Guid WalkDifficultyID { get; set; }

        //Navigation Property
        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }  
    }
}
