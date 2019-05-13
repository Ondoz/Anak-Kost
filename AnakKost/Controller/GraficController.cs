using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AnakKost.Controller
{
    class GraficController
    {
        private View.Grafic viewgrafic;
        private Model.HomeModel modelkeuangan;
        //construktor


        public GraficController(View.Grafic viewgrafic)
        {
            this.viewgrafic = viewgrafic;
            modelkeuangan = new Model.HomeModel();
           
        }
        public void Selectdatagrafic()
        {
            DataSet data = modelkeuangan.SelectHistory();
            viewgrafic.ListView.DataContext = data.Tables[0].DefaultView;
            
        }
      
     
    }
}
