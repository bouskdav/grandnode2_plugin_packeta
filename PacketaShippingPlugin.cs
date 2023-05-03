using Grand.Business.Core.Extensions;
using Grand.Business.Core.Interfaces.Common.Configuration;
using Grand.Business.Core.Interfaces.Common.Localization;
using Grand.Domain.Orders;
using Grand.Infrastructure.Plugins;

namespace Shipping.Packeta
{
    public class PacketaShippingPlugin : BasePlugin, IPlugin
    {
        #region Fields

        private readonly ISettingService _settingService;
        private readonly ITranslationService _translationService;
        private readonly ILanguageService _languageService;
        #endregion

        #region Ctor
        public PacketaShippingPlugin(
            ISettingService settingService,
            ITranslationService translationService,
            ILanguageService languageService)
        {
            _settingService = settingService;
            _translationService = translationService;
            _languageService = languageService;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Install plugin
        /// </summary>
        public override async Task Install()
        {
            //settings
            var settings = new PacketaShippingSettings {
                LimitMethodsToCreated = false,
            };
            await _settingService.SaveSetting(settings);

            //locales
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.FriendlyName", "Packeta Pickup");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.PluginName", "Packeta Pickup");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.PluginDescription", "Pick up at selected Packeta Pickup point");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.SelectBeforeProceed", "Please select a Pickup point before proceed");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.ShippingPointName", "Selected pickup point");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Shipping.Packeta.ChooseShippingPoint", "Select pickup point");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.Store", "Store");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.Warehouse", "Warehouse");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.Country", "Country");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.StateProvince", "State / province");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.Zip", "Zip");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.ShippingMethod", "Shipping method");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.From", "Order weight from");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.To", "Order weight to");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.AdditionalFixedCost", "Additional fixed cost");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.LowerWeightLimit", "Lower weight limit");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.PercentageRateOfSubtotal", "Charge percentage (of subtotal)");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.RatePerWeightUnit", "Rate per weight unit");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.LimitMethodsToCreated", "Limit shipping methods to configured ones");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.DataHtml", "Data");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Fields.DisplayOrder", "DisplayOrder");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.AddRecord", "Add record");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Formula", "Formula to calculate rates");
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Plugins.Shipping.Packeta.Formula.Value", "[additional fixed cost] + ([order total weight] - [lower weight limit]) * [rate per weight unit] + [order subtotal] * [charge percentage]");

            await base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override async Task Uninstall()
        {
            await base.Uninstall();
        }

        /// <summary>
        /// Returns a value indicating whether shipping methods should be hidden during checkout
        /// </summary>
        /// <param name="cart">Shoping cart</param>
        /// <returns>true - hide; false - display.</returns>
        public async Task<bool> HideShipmentMethods(IList<ShoppingCartItem> cart)
        {
            //you can put any logic here
            //for example, hide this shipping methods if all products in the cart are downloadable
            //or hide this shipping methods if current customer is from certain country
            return await Task.FromResult(false);
        }

        #endregion

    }

}
