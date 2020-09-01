using System;

namespace WpfAppUML {
    class Presenter {
        Model model;
        MainWindow mw;

        public Presenter(MainWindow mw) {
            this.mw = mw;
            this.model = new Model();
            mw.SomeEvent += Mw_SomeEvent;
        }

        private void Mw_SomeEvent(object sender, EventArgs e) {
            if(mw.txtBox.Text != null)
            mw.txtBox.Text = model.SomeMethod(mw.txtBox.Text);
            return;
        }
    }
}
