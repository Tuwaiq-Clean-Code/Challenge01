using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN
{
    public class NewDayNotifier
    {
        private List<INewDayEnterable> _subscribers = new List<INewDayEnterable>();
        public void Attach(INewDayEnterable subscriber) => _subscribers.Add(subscriber);
        public void AttachRange(IEnumerable<INewDayEnterable> subscribers) => _subscribers.AddRange(subscribers);
        public void Deattach(INewDayEnterable subscriber) => _subscribers.Remove(subscriber);

        public void NotifyAll()
        {
            foreach (var subscriber in _subscribers) subscriber.EnterNewDay();
        }
    }
}
