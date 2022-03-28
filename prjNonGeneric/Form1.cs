using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjNonGeneric
{
    public partial class frmNonGeneric : Form
    {
        public frmNonGeneric()
        {
            InitializeComponent();

            btnPrint.Click +=

                delegate (object sender, EventArgs e)
                {
                    printDictionary();
                    printHashset();
                    printQueue();

                };
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void printDictionary()
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("DIS1", 40);
            dictionary.Add("DIS2", 25);
            dictionary.Add("DIS3", 21);

            String strCourse = "DIS2";
            if (dictionary.ContainsKey(strCourse))
            {
                int Value = dictionary[strCourse];
                this.lstDictionary.Items.Add(strCourse + " has " + Value + " students.");
            }

            this.lstDictionary.Items.Add("Dictionary has " + dictionary.Count + " courses ");
        }
        private void printHashset()
        {
            string[] array1 =
            {
                "C#",
                "Java",
                "Java",
                "PHP",
                "HTML",
                "VB.net"
            };

            var hash = new HashSet<string>(array1);
            string[] array2 = hash.ToArray();
            this.lstHashset.Items.Add(string.Join(",", array2));
        }

        private void printQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);


            this.lstQueue.Items.Add("Results from the queue (FIFO)");
            foreach (var item in queue)
            {
                this.lstQueue.Items.Add(item);
            }

            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);

            this.lstQueue.Items.Add("Results from the stack (LIFO)");
            foreach (var item in stack)
            {
                this.lstQueue.Items.Add(item);
            }

        }

        private void frmNonGeneric_Load(object sender, EventArgs e)
        {

        }
    }
}
