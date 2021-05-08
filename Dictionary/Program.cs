using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Oyun = new MyDictionary<int, string>();
            Oyun.Add(1, "Valorant");
            Oyun.Add(2, "Leaque of Legends");
            Oyun.Add(3, "Counter Strike");
            Oyun.Add(4, "Fifa");
            Console.WriteLine(Oyun.Count);
        }
    }

    class MyDictionary<Tk,Tv>
    {
        Tk[] _dictionaryKeys;
        Tv[] _dictionaryValue;

        Tk[] _tempKeys;
        Tv[] _tempValue;

        public MyDictionary()
        {
            _dictionaryKeys = new Tk[0];
            _dictionaryValue = new Tv[0];
        }

        public void Add(Tk k, Tv v)
        {
            _tempKeys = _dictionaryKeys;
            _tempValue = _dictionaryValue;

            _dictionaryKeys = new Tk[_dictionaryKeys.Length + 1];
            _dictionaryValue = new Tv[_dictionaryValue.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _dictionaryKeys[i] = _tempKeys[i];
                _dictionaryValue[i] = _tempValue[i];
            }

            _dictionaryKeys[_dictionaryKeys.Length - 1] = k;
            _dictionaryValue[_dictionaryValue.Length - 1] = v;
        }


        public int Count
        {
            get { return _dictionaryKeys.Length; }

        }


    }
}
