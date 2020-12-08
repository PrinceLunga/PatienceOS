using POSS.Models.CartHistory;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSS.Services.CartHistoryService.Interface
{
    public interface ICartHistoryService
    {
        public string AddToCartHistory(CartHistoryModel model);
        public List<CartHistoryModel> ViewCartHistory();
        public string UpdateCartHistory(CartHistoryModel model);
        public string DeleteCartHistory(CartHistoryModel model);
        public CartHistoryModel FindHistoryById(int id);
    }
}
