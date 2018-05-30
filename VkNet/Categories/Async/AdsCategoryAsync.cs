﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;

namespace VkNet.Categories
{
    /// <inheritdoc />
    public partial class AdsCategory
    {
        /// <inheritdoc />
        public async Task<ReadOnlyCollection<AdsAccount>> GetAccountsAsync()
        {
            return await TypeHelper.TryInvokeMethodAsync(() => _vk.Ads.GetAccounts());
        }

        /// <inheritdoc/>
        public async Task<ReadOnlyCollection<Ad>> GetCampaignsAsync(AdsGetAdsParams @params)
        {
            return await TypeHelper.TryInvokeMethodAsync(() => _vk.Ads.GetAds(@params));
        }

        /// <inheritdoc/>
        public async Task<ReadOnlyCollection<AdsCampaign>> GetCampaignsAsync(AdsGetCampaignsParams @params)
        {
            return await TypeHelper.TryInvokeMethodAsync(() => _vk.Ads.GetCampaigns(@params));
        }
    }
}
