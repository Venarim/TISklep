using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.DAL;
using TISklep.Models;

namespace TISklep.Infrastructure
{
    public static class CartManager
    {
        public static int RemoveFromCart(ISession session, int id)
        {
            var cart = GetItems(session);

            var thisFilm = cart.Find(i => i.Film.MovieId == id);

            int ilosc = 0;

            if(thisFilm == null)
            {
                return ilosc;
            }

            if(thisFilm.Ilosc > 1)
            {
                thisFilm.Ilosc--;
                ilosc = thisFilm.Ilosc;
            }
            else
            {
                cart.Remove(thisFilm);
            }

            SessionHelper.SetObjectAsJson(session, Consts.CartSessionKey, cart);

            return ilosc;
        }

        public static List<CartItem> GetItems(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(session, Consts.CartSessionKey);

            if(cart == null)
            {
                cart = new List<CartItem>();
            }

            return cart;
        }

        public static decimal GetCartValue(ISession session)
        {
            var cart = GetItems(session);
            return cart.Sum(i => i.Ilosc * i.Film.Price);
        }

        public static void AddToCart(ISession session, MoviesContext db, int id)
        {
            var cart = GetItems(session);

            var thisFilm = cart.Find(i => i.Film.MovieId == id);

            if(thisFilm != null)
            {
                thisFilm.Ilosc++;
            }
            else
            {
                var newCartItem = db.Movies.Where(f => f.MovieId == id).SingleOrDefault();

                if(newCartItem != null)
                {
                    var cartItem = new CartItem()
                    {
                        Film = newCartItem,
                        Ilosc = 1,
                        Wartosc = newCartItem.Price
                    };

                    cart.Add(cartItem);
                }
            }

            SessionHelper.SetObjectAsJson(session, Consts.CartSessionKey, cart);
        }
    }
}
