using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaEjemplo
{
    interface List<G>
    {
        void addAtTail(G data);
        void addAtFront(G data);
        void remove(int index);
        void removeAll();
        void setAt(int index, G data);
        G getAt(int index);
        void removeAllWithValue(G data);
        int getSize();
        Iterator<G> getIterator();
        bool isEmpty();
    }
}
