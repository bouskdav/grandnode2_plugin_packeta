using Grand.Domain;
using Grand.Domain.Data;
using Grand.Infrastructure.Caching;

namespace Shipping.Packeta.Services
{
    public partial class PacketaShippingService : IPacketaShippingService
    {
        //#region Constants
        //private const string SHIPPINGBYWEIGHT_ALL_KEY = "Grand.shippingbyweight.all-{0}-{1}";
        //private const string SHIPPINGBYWEIGHT_PATTERN_KEY = "Grand.shippingbyweight.";
        //#endregion

        //#region Fields

        //private readonly IRepository<PacketaShippingRecord> _sbwRepository;
        //private readonly ICacheBase _cacheBase;

        //#endregion

        //#region Ctor

        //public PacketaShippingService(ICacheBase cacheBase,
        //    IRepository<PacketaShippingRecord> sbwRepository)
        //{
        //    _cacheBase = cacheBase;
        //    _sbwRepository = sbwRepository;
        //}

        //#endregion

        //#region Methods

        //public virtual async Task DeletePacketaShippingRecord(PacketaShippingRecord shippingPacketaRecord)
        //{
        //    if (shippingPacketaRecord == null)
        //        throw new ArgumentNullException(nameof(shippingPacketaRecord));

        //    await _sbwRepository.DeleteAsync(shippingPacketaRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //public virtual async Task<IPagedList<PacketaShippingRecord>> GetAll(int pageIndex = 0, int pageSize = int.MaxValue)
        //{
        //    string key = string.Format(SHIPPINGBYWEIGHT_ALL_KEY, pageIndex, pageSize);
        //    return await _cacheBase.GetAsync(key, () =>
        //    {
        //        var query = from sbw in _sbwRepository.Table
        //                    select sbw;

        //        return Task.FromResult(new PagedList<PacketaShippingRecord>(query, pageIndex, pageSize));
        //    });
        //}

        //public virtual async Task<PacketaShippingRecord> FindRecord(string shippingMethodId,
        //    string storeId, string warehouseId,
        //    string countryId, string stateProvinceId, string zip, double weight)
        //{
        //    if (zip == null)
        //        zip = string.Empty;
        //    zip = zip.Trim();

        //    var existingRates = (await GetAll())
        //        .Where(sbw => sbw.ShippingMethodId == shippingMethodId && weight >= sbw.From && weight <= sbw.To)
        //        .ToList();

        //    if (!string.IsNullOrEmpty(warehouseId))
        //        existingRates = existingRates.Where(x => x.WarehouseId == warehouseId).Any() 
        //            ? existingRates.Where(x => x.WarehouseId == warehouseId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.WarehouseId)).ToList();

        //    if (!string.IsNullOrEmpty(storeId))
        //        existingRates = existingRates.Where(x => x.StoreId == storeId).Any() 
        //            ? existingRates.Where(x => x.StoreId == storeId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.StoreId)).ToList();
            
        //    if (!string.IsNullOrEmpty(countryId))
        //        existingRates = existingRates.Where(x => x.CountryId == countryId).Any() 
        //            ? existingRates.Where(x => x.CountryId == countryId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.CountryId)).ToList();

        //    if (!string.IsNullOrEmpty(stateProvinceId))
        //        existingRates = existingRates.Where(x => x.StateProvinceId == stateProvinceId).Any() 
        //            ? existingRates.Where(x => x.StateProvinceId == stateProvinceId).ToList() 
        //            : existingRates.Where(x => string.IsNullOrEmpty(x.StateProvinceId)).ToList();

        //    if (!string.IsNullOrEmpty(zip))
        //        existingRates = existingRates.Where(x => x.Zip == zip).Any()
        //           ? existingRates.Where(x => x.Zip == zip).ToList()
        //           : existingRates.Where(x => string.IsNullOrEmpty(x.Zip)).ToList();

        //    return existingRates.FirstOrDefault();

        //}

        //public virtual Task<PacketaShippingRecord> GetById(string shippingPacketaRecordId)
        //{
        //    return _sbwRepository.GetByIdAsync(shippingPacketaRecordId);
        //}

        //public virtual async Task InsertPacketaShippingRecord(PacketaShippingRecord shippingPacketaRecord)
        //{
        //    if (shippingPacketaRecord == null)
        //        throw new ArgumentNullException(nameof(shippingPacketaRecord));

        //    await _sbwRepository.InsertAsync(shippingPacketaRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //public virtual async Task UpdatePacketaShippingRecord(PacketaShippingRecord shippingPacketaRecord)
        //{
        //    if (shippingPacketaRecord == null)
        //        throw new ArgumentNullException(nameof(shippingPacketaRecord));

        //    await _sbwRepository.UpdateAsync(shippingPacketaRecord);

        //    await _cacheBase.RemoveByPrefix(SHIPPINGBYWEIGHT_PATTERN_KEY);
        //}

        //#endregion
    }

}
