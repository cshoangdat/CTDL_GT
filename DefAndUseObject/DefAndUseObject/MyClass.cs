using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefAndUseObject
{
    class MyClass : IMyInterface
    {
        //1. ₫ịnh nghĩa các thuộc tính vật lý 
        private int m_x;
        protected int[] arr = new int[100];
        //2. ₫ịnh nghĩa các tác vụ quản lý ₫ối tượng 
        public MyClass()
        {
            this.Click += new EventHandler(button1_Click);
        }
        ~MyClass() { } //hàm destructor 
                       //3. ₫ịnh nghĩa ₫ối tượng ₫ại diện hàm chức năng 
        public delegate void EventHandler(Object sender, EventArgs e);
        //4. ₫ịnh nghĩa sự kiện Click ₫ược xử lý bởi delegate EventHandler. 
        public event EventHandler Click;
        //5. ₫ịnh nghĩa các tác vụ & toán tử chức năng 
        public void button1_Click(object sender, System.EventArgs e)
        {
            Console.WriteLine("Ham xu lý Click cua class MyClass chay");
        }
        public void func2()
        {
        Console.WriteLine("Ham MyClass.func2() ₫ang chạy");
        }
        //6. ₫ịnh nghĩa tác vụ kích hoạt sự kiện Click 
        public void OnClick(Object sender, EventArgs e)
        {
            if (Click != null) Click(sender, e);
        }
        //7. ₫ịnh nghĩa thuộc tính luận lý x 
        public int x
        {
            get { return m_x; }
            set { m_x = value; }
        }
        //8. ₫ịnh nghĩa indexer 
        public int this[int index]
        {
            get
            {
                //kiểm tra giới hạn ₫ể quyết ₫ịnh 
                if (index < 0 || index >= 100) { return 0; }
                else { return arr[index]; }
            }
            set
            {
                if (0 <= index && index < 100) { arr[index] = value; }
            }
        }
    } //kết thúc class
}
