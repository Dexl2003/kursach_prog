
using System.Collections;

namespace kursach_prog
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            listBox1.Items.AddRange(fileStr()); // Вывод файла в ListBox
        }

        public class Sals : IComparable, IList<int> //Вложенный класс для реализации сортировки массива данных по типу Ключ, Значение
        {

            public Sals() { }

            public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int ID { get; set; }
            public string name { get; set; }
            public int price { get; set; }

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(int item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object? obj)
            {
                if ((obj == null) || (!(obj is Sals)))
                    return 0;
                else
                    return string.Compare(name, ((Sals)obj).name);
            }

            public bool Contains(int item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(int[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<int> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(int item)
            {
                throw new NotImplementedException();
            }



            public void Insert(int index, int item)
            {
                throw new NotImplementedException();
            }

            public bool Remove(int item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        public string[] fileStr()
        {
            listBox1.Items.Clear();
            string path = @"C:\kurs\saleList.txt"; // Путь к файлу
            using (StreamReader sr = new StreamReader(path))
            {
                string str = sr.ReadToEnd(); // Чтение файла
                string[] strList = str.Split('\n'); // Сплит файла по строкам

                return strList;
            }

        }

        public (List<Sals>, string[]) createList(List<Sals> nameList)
        {
            listBox1.Items.Clear();
            string path = @"C:\kurs\saleList.txt"; // Путь к файлу
            using (StreamReader sr = new StreamReader(path)) //Конструкция using для реализации интерфейса IDisposable
            {
                int i1 = 1;
                int j1 = 3;

                string str = sr.ReadToEnd(); // Чтение 
                string[] allword = str.Split(); // Сплит по словам
                string[] allWordLine = str.Split('\n'); // Сплит по строкам
                List<Sals> name = new List<Sals>(2); //List с типом вложенного класса

                //Добавление массива слов из файла в лист с параметрами (Name | Price)
                for (int k = 0; k < allWordLine.Length; k++)
                {
                    for (int i = i1; i < 147; i = i1)
                    {
                        if (!name.Contains(new Sals() { name = allword[i] }))
                        {
                            for (int j = j1; j < 149; j = j1)
                            {

                                name.Add(new Sals() { name = allword[i], price = int.Parse(allword[j]) });
                                j1 = j1 + 5;
                                Console.WriteLine(name.Count);
                                break;
                            }
                            i1 = i1 + 5;
                            break;
                        }
                        else
                        {
                            i1 = i1 + 5;
                            j1 = j1 + 5;
                            break;
                        }
                    }
                }

                //Локальная переменная для возврата значений List<Sals> и string[]
                var tuple = (name: name, allWordLine: allWordLine);

                return tuple;
            }
        }

        private void top_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string path = @"C:\kurs\saleList.txt"; // Путь к файлу
            using (StreamReader sr = new StreamReader(path))
            {
                List<Sals> name = new List<Sals> { };

                name = createList(name).Item1;
                string[] allwordLine = createList(name).Item2;


                for (int z = allwordLine.Length - 11; z >= 0; z--)
                {
                    name.RemoveAt(z);
                }

                name.Sort(delegate (Sals x, Sals y) //сортировка листа по цене
                {
                    if (x.price == null && y.price == null) return 0;
                    else if (x.price == null) return -1;
                    else if (y.price == null) return 1;
                    else return y.price.CompareTo(x.price);
                });


                foreach (Sals sals in name) //вывод
                {
                    listBox1.Items.Add(sals.name + " " + sals.price);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        public void sortByPrice()
        {
            if (this.from.Text != "" || this.before.Text != "") // Проверка на пустое поле От
            {
                this.sale.Checked = true;
                int _from = 0;
                int _before = 0;

                if (this.from.Text != "")
                {
                    _from = int.Parse(this.from.Text);
                }

                    if (this.before.Text != "")
                {
                    _before = int.Parse(this.before.Text);
                }

                List<Sals> name = new List<Sals> { };

                name = createList(name).Item1;
                string[] allwordLine = createList(name).Item2;

                while (name.Exists(x => x.price.Equals(_from - 1))) //Удаление значений до От
                {
                    try
                    {
                        name.RemoveAt(0);
                    }
                    catch (System.ArgumentOutOfRangeException) { }
                }

                if (this.before.Text != "")//Прповерка на пустое поле До
                {
                    while (name.Exists(x => x.price.Equals(_before + 1))) // Удаление значений после До
                    {
                        try
                        {
                            name.RemoveAt(name.Count - 1);
                        }
                        catch (System.ArgumentOutOfRangeException) { }
                    }
                }

                foreach (Sals sals in name) //вывод
                {
                    listBox1.Items.Add(sals.name + " " + sals.price);
                }

                if (_from >= _before) //Проверка на разность полей
                {
                    _before = 0;
                }

            }
            else  //Очистка выбора radioButton и вывод ошибки
            {
                sale.Checked = false;
                errorText.Text = "Введите хотя бы одно значение";
                fullList.Checked = true;
                listBox1.Items.AddRange(fileStr());
            }
        }

        private void sale_CheckedChanged(object sender, EventArgs e)
        {
            sortByPrice();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void fullList_CheckedChanged(object sender, EventArgs e) //Defaul позиция RadioButton
        {
            listBox1.Items.AddRange(fileStr()); // Вывод файла в ListBox
        }

        private void from_TextChanged(object sender, EventArgs e)
        {
            sortByPrice();
        }

        private void before_TextChanged(object sender, EventArgs e)
        {
            sortByPrice();
        }
    }
}