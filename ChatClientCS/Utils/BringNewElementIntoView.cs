using System.Collections.Specialized;
using System.Windows.Interactivity;
using System.Windows.Controls;
using System.Windows;

namespace ChatClientCS.Utils
{
    class BringNewElementIntoView : Behavior<ItemsControl>
    {
        private INotifyCollectionChanged notifier;

    }
}
