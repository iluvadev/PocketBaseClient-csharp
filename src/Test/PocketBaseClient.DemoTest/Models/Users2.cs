
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using pocketbase_csharp_sdk.Json;
using PocketBaseClient.Orm;
using PocketBaseClient.Orm.Attributes;
using PocketBaseClient.Orm.Json;
using PocketBaseClient.Orm.Validators;
using PocketBaseClient.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PocketBaseClient.DemoTest.Models
{
    public partial class Users2 : ItemBase
    {
        #region Collection
        private static CollectionBase? _Collection = null;
        /// <inheritdoc />
        [JsonIgnore]
        public override CollectionBase Collection => _Collection ??= DataServiceBase.GetCollection<Users2>()!;
        #endregion Collection

        #region Field Properties
        private string? _PublicName = null;
        /// <summary> Maps to 'public_name' field in PocketBase </summary>
        [JsonPropertyName("public_name")]
        [PocketBaseField(id: "2caltbcc", name: "public_name", required: false, system: false, unique: false, type: "text")]
        [Display(Name = "Public_name")]
        public string? PublicName { get => Get(() => _PublicName); set => Set(value, ref _PublicName); }

        #endregion Field Properties

        /// <inheritdoc />
        public override void UpdateWith(ItemBase itemBase)
        {
            base.UpdateWith(itemBase);

            if (itemBase is Users2 item)
            {
                PublicName = item.PublicName;

            }
        }

        #region Collection
        public static CollectionUsers2 GetCollection() 
            => (CollectionUsers2)DataServiceBase.GetCollection<Users2>()!;
        #endregion Collection

        #region GetById
        public static Users2? GetById(string id, bool reload = false) 
            => GetByIdAsync(id, reload).Result;

        public static async Task<Users2?> GetByIdAsync(string id, bool reload = false)
            => await DataServiceBase.GetCollection<Users2>()!.GetByIdAsync(id, reload);
        #endregion GetById
    }
}
