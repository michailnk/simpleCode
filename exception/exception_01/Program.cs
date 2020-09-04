using System;
// microsoft утверждает что блок finally выполнится всегда - ответ для собеседования

namespace exception_01 {

    class ClassWithException {
        public void ThrowInner() {
            throw new Exception("This is inner exception!");
        }
        public void CathInner() {
            try {
                this.ThrowInner();
            }
            catch(Exception e) {
                throw new Exception("this is outer exception!",e);
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            ClassWithException instance = new ClassWithException();
            //instance.CathInner(); // try call
            try {
                instance.CathInner();
            }
            catch(Exception ex) {
                Console.WriteLine($"exception caught: {ex.Message}");
                Console.WriteLine($"inner exception: {ex.InnerException.Message}");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
