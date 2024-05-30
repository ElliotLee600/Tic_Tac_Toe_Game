using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Utils
{
    public interface ISubscriber
    {
        public void update();

        public Boolean isActive() {
            return false;
        }

        public void setActive(Boolean newActive);
    }
}
