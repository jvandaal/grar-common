namespace Be.Vlaanderen.Basisregisters.GrAr.Import.Processing
{
    using System;

    public class ImportBatchStatus
    {
        public string ImportFeedId { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
        public bool Completed { get; set; }
    }
}