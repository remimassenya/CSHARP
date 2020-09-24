using System;
using System.Collections;
using System.Collections.Generic;

namespace SocieteEnumeration
{
    class ListeEnumeration : IEnumerator<Liste>
    {
        private Liste _List;
        private int _indiceCourant;

        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public ListeEnumeration(Liste list)
        {
            _List = list;
            _indiceCourant = 0;
        }

        public object Current()
        {
            return _List[_indiceCourant].Objet;
        }


        public bool MoveNext()
        {
            _indiceCourant++;
            if (_indiceCourant > _List.nbliste - 1)
                return false;
            return true;
        }

        public void Reset()
        {
            _indiceCourant = 0;
        }

        public void Dispose()
        {
            _List = null;
            _indiceCourant = 0;
        }
    }
}