open System
open System.Windows
open System.Windows.Controls

// helper function, if there's no parenthesis, then it would be value
let loadWindow() = 
    // points to resource, syntax assembly;component/XamlFile.xaml
    let resourceLocator = new Uri("/HelloWPF;component/MainWindow.xaml", UriKind.Relative)
    // :?> is a cast
    let window = Application.LoadComponent(resourceLocator) :?> Window
    (window.FindName("clickButton") :?> Button).Click.Add(
        // lambda expression as a event handler, no parameters, return value is ignored
        fun _ -> MessageBox.Show("Hello World!") |> ignore)
    window // return value

// "main program"
[<STAThread>]
(new Application()).Run(loadWindow()) |> ignore
    