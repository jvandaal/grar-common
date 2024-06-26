namespace Be.Vlaanderen.Basisregisters.GrAr.Contracts.AddressRegistry
{
    using Common;

    public class AddressRemovalWasCorrected : IQueueMessage
    {
        public int StreetNamePersistentLocalId { get; }

        public int AddressPersistentLocalId { get; }

        public string Status { get; }

        public string HouseNumber { get; }

        public string? BoxNumber { get; }

        public string GeometryMethod { get; }

        public string GeometrySpecification { get; }

        public string ExtendedWkbGeometry { get; }

        public bool OfficiallyAssigned { get; }

        public string? PostalCode { get; }

        public int? ParentPersistentLocalId { get; }

        public Provenance Provenance { get; }

        public AddressRemovalWasCorrected(
            int streetNamePersistentLocalId,
            int addressPersistentLocalId,
            string status,
            string houseNumber,
            string? boxNumber,
            string geometryMethod,
            string geometrySpecification,
            string extendedWkbGeometry,
            bool officiallyAssigned,
            string? postalCode,
            int? parentPersistentLocalId,
            Provenance provenance)
        {
            StreetNamePersistentLocalId = streetNamePersistentLocalId;
            AddressPersistentLocalId = addressPersistentLocalId;
            Status = status;
            HouseNumber = houseNumber;
            BoxNumber = boxNumber;
            GeometryMethod = geometryMethod;
            GeometrySpecification = geometrySpecification;
            ExtendedWkbGeometry = extendedWkbGeometry;
            OfficiallyAssigned = officiallyAssigned;
            PostalCode = postalCode;
            ParentPersistentLocalId = parentPersistentLocalId;
            Provenance = provenance;
        }
    }
}
