using cuteqt.Helper.MVVM;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace cuteqt.ViewModels
{
    public class ResultViewModel : ViewModelBase
    {
        public ObservableCollection<Result> ResultCollection { get; } = new ObservableCollection<Result>();

        public ResultViewModel()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            var img = new BitmapImage(new Uri(@"D:\Directories\Pictures\Development\link\2x\baseline_link_white_36dp.png"));
            ResultCollection.Add(new Result() { Text = "Visual Studio 2015", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2015.lnk", Icon = img });
            ResultCollection.Add(new Result() { Text = "Visual Studio 2017", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017.lnk", Icon = img });
            ResultCollection.Add(new Result() { Text = "Visual Studio Code", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio Code.lnk", Icon = img });
            ResultCollection.Add(new Result() { Text = "Visual Studio Installer", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio Installer.lnk", Icon = img });
            ResultCollection.Add(new Result() { Text = "Blend for Visual Studio 2015", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Blend for Visual Studio 2015.lnk", Icon = img });
            ResultCollection.Add(new Result() { Text = "Blend for Visual Studio 2017", SubText = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Blend for Visual Studio 2017.lnk", Icon = img });
        }
    }

    public class Result
    {
        public string Text { get; set; }

        public string SubText { get; set; }

        public BitmapImage Icon { get; set; }
    }
}