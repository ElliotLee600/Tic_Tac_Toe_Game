using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game.Utils
{
    public interface IPublisher
    {
        public void addSubscriber(ISubscriber subscriber);
        public void removeSubscriber(ISubscriber subscriber);
        public void notifySubscribers();
    }
}
