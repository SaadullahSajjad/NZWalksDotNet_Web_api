namespace NZWalks.API.Models.Domain
{
    public class Walk
    {


        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public double LengthInKm { get; set; }
        //to make property nullable use ?.
        public string? WalkImageUrl { get; set; }
        // now we have to define relationship b/w models so,
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }


        //in order to connect with Diffculty.cs model we should have to write some
        //navigation properties
        //these are defining one-one relation b/w walk and Difficuty and walk and Region
        public Difficulty Difficulty { get; set;}

        public Region Region { get; set; }





    }
}
