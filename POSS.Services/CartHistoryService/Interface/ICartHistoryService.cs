using POSS.Models.CartHistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.CartHistoryService.Interface
{
    public interface ICartHistoryService
    {
        public CartHistoryModel AddToCartHistory(CartHistoryModel model);
        public List<CartHistoryModel> ViewCartHistory();
        public CartHistoryModel UpdateCartHistory(int modelCartHistoryId, CartHistoryModel model);
        public string DeleteCartHistory(int modelCartHistoryId);
    }
}
