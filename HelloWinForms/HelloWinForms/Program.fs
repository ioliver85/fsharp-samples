open System.Windows.Forms

// datatype record
type Person = { Name: string; Age: int }

let testData =
    // [| is instantiate array
    [|
        { Name = "Harry"; Age = 37};
        { Name = "Risto"; Age = 16};
        { Name = "Erno"; Age = 33 }
    |]

// note: new is not necessary, if type implements IDisposable
// Form doesn't have constructor parameters; Text is a property and this calls its accessor
let form = new Form(Text = "F# Windows Form")

let dataGrid = new DataGridView(Dock=DockStyle.Fill, DataSource = testData)
form.Controls.Add(dataGrid)

Application.Run(form)