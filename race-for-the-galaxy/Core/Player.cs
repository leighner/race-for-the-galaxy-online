using race_for_the_galaxy.GameData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race_for_the_galaxy.Core
{
    public class Player
    {
        Tableau mTableau;
        string mPlayerName = string.Empty;
        private Guid mId;

        public Player(string playerName)
        {
            mTableau = new Tableau();
            mPlayerName = playerName;
            mId = Guid.NewGuid();
        }


        public string MPlayerName
        {
            get
            {
                return mPlayerName;
            }
        }
    }
}
