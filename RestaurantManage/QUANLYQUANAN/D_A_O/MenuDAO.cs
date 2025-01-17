﻿using QUANLYQUANAN.D_T_O;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYQUANAN.D_A_O
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.NAME, bi.COUNT, f.PRICE, f.PRICE*bi.COUNT AS totalPrice FROM dbo.BILLINFO AS bi, dbo.BILL AS b, dbo.FOOD AS f WHERE bi.IDBILL = b.id AND bi.IDFOOD = f.id AND b.STATUS = 0 AND b.IDTABLE = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
