Imports System
Imports System.IO

' Public Class BalfeBikeInterface contains all of the code for the interface
' Public Class declares global variables
Public Class BalfeBikeInterface

    ' Need to create global arrays because more than one sub-routine will handle this data
    Dim bikeData As New ArrayList
    ' Declare bikeData as global array, this array will handle data from textdatabase.txt
    Dim polygonList As New ArrayList
    ' Declare polygonList as global array, this array will hande data from the image coordinate .txt files


    ' THIS PRIVATE SUB-ROUTINE LoadData, LOADS DATA FROM THE DATABASE FILE INTO THE PROGRAM
    Private Sub LoadData()

        ' Debug.WriteLine("Loading data")

        Try
            ' "Try" runs the following indented code and if the code crashes it will run the code indented in "Catch"
            Using sr As New StreamReader("textdatabase.txt")
                '  Declare an identfier given to the stream reader as 'sr' to stream the file "textdatabase.txt", if file doesn't exsist the code crashes
                Do While sr.Peek() >= 0
                    ' While the text file has data ahead of the line that it is reading it will
                    Dim line As String
                    ' Declare a variable with the identifier 'line' as a string data type
                    line = sr.ReadLine
                    ' The variable 'line' is given the contents from 'sr'
                    Dim parts() As String = line.Split("|")
                    ' Declare an array with the identifier 'parts' with a string property from the variable 'line'. This data then split each time '|' occurs
                    Dim entry As New ArrayList
                    ' Declare an array with the identifier 'entry' as a new Array list
                    For Each part As String In parts
                        ' for each seperated part as a string in the array 'parts'
                        entry.Add(part)
                        ' Add the seperated parts to the array 'entry'
                    Next
                    ' After for each part has been addded to the entry array 
                    bikeData.Add(entry)
                    ' Add all the data from the array entry as one item to the array 'bikeData' (creates a 2D array)
                Loop
                'Loop the while condition
            End Using
            ' End procedure after while loop
        Catch e As Exception
            ' report error if the code crashes
            'Debug.WriteLine("The file could not be read:")
            'Debug.WriteLine(e.Message)
        End Try
        ' End Try after the code successfully executes or reports an error

    End Sub ' End sub-routine

    ' THIS PRIVATE SUB-ROUTINE LoadImagemap, LOADS DATA FROM THE IMAGE MAP COORDINATE FILES USING THE DATA FROM bikeData ARRAY
    Private Sub LoadImageMap()
        For i = 0 To bikeData.Count - 1
            ' Until i = the number of rows in bikeData Array it will perform this procedure

            Dim pointsList As New ArrayList
            ' Declare pointsList as an Array
            Dim path As String = "Image Coordinates\" + bikeData(i)(3)
            ' Declare variable path as string data type
            ' path = "Image Coordinates\<name of textfile for coordinate from bikeData(i)(3)>" 

            If bikeData(i)(3) = "nil" Then
                ' If the fourth row of i = 'nil' then perform this block of code
                Dim point As New Point
                ' Declare point as new cooridnate point
                point.X = -1
                ' Declare the x cordinate as -1 so the point is outside of the images area 
                point.Y = -1
                ' Declare the y cordinate as -1 so the point is outside of the images area 
                pointsList.Add(point)
                ' Add x coordinate to pointsList array
                pointsList.Add(point)
                ' Add y coordinate to pointList array

                ' THE REASON FOR THIS 'IF' STATEMENT IS TO ALLOW THE DATA WITH AN IMAGE COORDINATE VALUE OF 'NIL' ARE NOT ADDED TO THE DIAGRAM
                ' THIS IS DONE BY ADDING THE COORDINATES OUTSIDE OF THE IMAGES AREA (-1,-1)

            Else
                ' If the fourth row of i contains a text file for image coordinates then perform this block of code 
                Try
                    ' Try executing this block of code, if error go to Catch

                    Using sr As New StreamReader(path)
                        ' Identifier as 'sr' uses the string value from varibale 'path' as a path to the coordinates file location
                        Do While sr.Peek() >= 0
                            ' While the text file has data ahead of the line that it is reading it will
                            Dim line As String
                            ' Declare variable 'line' as a string data type
                            line = sr.ReadLine
                            ' The value of line = files contents from the path 'sr'
                            Dim parts() As String = line.Split(",")
                            ' Declare parts as an string array 
                            ' parts = the string ontent from line split each time ',' occurs
                            ' first item (x value) is stored in (0), second (y value) item stored in (1)
                            Dim point As New Point
                            ' Declare point as new cooridnate point
                            point.X = CInt(parts(0))
                            ' converts string datatype of part(0) into coordinate integer  and stored as x coordinate
                            point.Y = CInt(parts(1))
                            ' converts string datatype of part(1) into coordinate integer  and stored as y coordinate
                            pointsList.Add(point)
                            ' Adds these coorinates to the image
                        Loop
                        ' Loops while statement
                    End Using
                    ' Ends 'Using' statement

                    ' THIS BLOCK OF CODE WILL RUN IF THE 'Try' ROUTINE MEETS AN ERROR
                    ' THE REASON FOR THIS CODE IS TO HANDLE THE DATA WITH AN UNRECOGNISABLE IMAGE COORDINATE VALUE
                    ' THIS UNRECOGNISABLE DATA IS TREATED AS IF IT WAS 'nil'
                Catch e As Exception
                    'Debug.WriteLine("The file could not be read:")
                    'Debug.WriteLine(e.Message)
                    Dim point As New Point
                    ' Declare point as new cooridnate point
                    point.X = -1
                    ' Declare the x cordinate as -1 so the point is outside of the images area 
                    point.Y = -1
                    ' Declare the y cordinate as -1 so the point is outside of the images area 
                    pointsList.Add(point)
                    ' Add x coordinate to pointList array
                    pointsList.Add(point)
                    ' Add y coordinate to pointList array
                End Try
                ' Ends 'Try' statement
            End If
            ' Ends 'If' statement

            polygonList.Add(pointsList)
            'Adds the data gathered from pointsList to the global array PoylgonList 
        Next
        ' Ends 'For' statement

    End Sub ' End Sub-routine

    ' THIS PRIVATE SUB-ROUTINE Button_Click, calls a procedure to handle the users request 
    Private Sub Button_Click(sender As Object, e As EventArgs)

        loadDataForIndex(sender.tag)
        ' When a button is clicked it will execute this sub-rountine and send the value of the buttons tag as the parameter

    End Sub ' End Sub-routine 

    ' THIS PRIVATE SUB-ROUTINE loadDataForButtonIndex, USES IT'S PARAMETER TO LOCATE DATA FROM bikeData ARRAY 
    ' The data located will be applied to ProductName, PriceRange, ProductImage and ProductDescription
    Private Sub loadDataForIndex(ByVal index As Integer)
        ' The parameter index = the button tag

        ProductName.Text = bikeData(index)(0)
        ' the label ProductName is given a text string value from the 2D array bikeData where index is row and 0 is collumn

        RetailPriceRange.Text = "Retail Price Range:"
        ' The label RetailPrice range is given a text string value of "Retail Price Range:"
        PriceRange.Text = "£" + bikeData(index)(1)
        ' The label PriceRange is given a text string value "£" + from the 2D array bikeData where index is row and 1 is collumn


        ' This secetion allows the program where the file images are stored reletive to itself, which means i could move the program anywhere on any machine
        ' and as long as the data folders are there it will work
        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly().CodeBase
        ' Declare path as a strig variable 
        ' path = the path of the executable file
        path = path.Replace("file:///", "")
        ' removes "file:///" from the front of path
        path = path.Replace("/", "\")
        ' replaces '/' with '\'
        path = System.IO.Path.GetDirectoryName(path)
        ' path = the folder of the executable file
        ProductImage.Image = Image.FromFile(path + "\Images\" + bikeData(index)(2))
        ' Append \Images\ and the image file name to path

        ProductDescription.Text = bikeData(index)(4)
        ' The rich text box ProductDescription is given the text value from 2D array bikeData where index is row and 4 is collumn

    End Sub ' End Sub-routine

    ' THIS PRIVATE SUB-ROUTINE BalfeBikeInterface_Load, WILL EXECUTE AS SOON AS THE INTERFACE OPENS
    ' THIS IS TO SET UP THE PROGRAM
    Private Sub BalfeBikeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The two lines of code bellow allows the program to go full screen
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None ' Ths line removes the boardes of the program
        Me.WindowState = FormWindowState.Maximized ' This line maximises the program to fit the screen size

        LoadData() ' this is the first sub routine that will be called in the program

        LoadImageMap() ' this is the second sub routine that will be called in the program

        CreateButtons() ' this is the third sub routine that will be called in the program

    End Sub ' End Sub-routine

    ' THIS PRIVATE FUNCTION isPointInsidePolygon, finds out if the position of the click is inside the area of the polygon and if so returns the value TRUE otherwise FASLE 
    Private Function isPointInsidePolygon(ByVal point As Point, ByVal pointsList As ArrayList) As Boolean

        Dim j As Integer = 0
        ' Decalre variable j as integer, with the value of 0
        Dim result As Boolean = False
        ' Declare variable result as boolean, with the value of False
        For i = 0 To pointsList.Count - 1
            ' Do the following code 0 to pointsList.Count - 1 times  (until i = pointsList.Count - 1)
            If i = 0 Then
                ' The first time this code executes i will equal to 0, 
                j = pointsList.Count - 1
                ' j = the number of items in the array pointsList
            Else
                j = i - 1
                ' After the first incrementation of i, this code will execute because i will be greater than 0
            End If
            ' End 'If' statement
            
            ' I found the formula bellow on the internet, I am not entierelly sure how this code works but i am familliar with Visual Basic and C to be able to translate this code from C to VB. 
            ' The orginal code i found is commented bellow at the end of the function, in C and the website address where i found the fomula 
            If ((pointsList(i).Y > point.Y) <> (pointsList(j).Y > point.Y)) And (point.X < (pointsList(j).X - pointsList(i).X) * (point.Y - pointsList(i).Y) / (pointsList(j).Y - pointsList(i).y) + pointsList(i).X) Then
                ' The code bellow works out if the value is inside the polygon
                ' If so result will report back true, otherwise nothing changes and Ends 'If' statement

                result = Not result
                ' result = False, so Not result means = True 
            End If
            ' End 'If' statement

        Next
        ' increment i (i = i +1)

        Return result
        ' Return value of result to BikeDiagram_Click





        ' C code of polygon function from http://www.codeproject.com/Tips/84226/Is-a-Point-inside-a-Polygon
        'int pnpoly(int nvert, float *vertx, float *verty, float testx, float testy) {
        '  int i, j, c = 0;
        '  for (i = 0, j = nvert-1; i < nvert; j = i++) {
        '    if ( ((verty[i]>testy) != (verty[j]>testy)) && (testx < (vertx[j]-vertx[i]) * (testy-verty[i]) / (verty[j]-verty[i]) + vertx[i]) )
        '       c = !c;
        '  }
        '  return c;
        '}

    End Function ' End Function

    ' THIS PRIVATE SUB-ROUTINE CreateButtons, USES THE DATA FROM bikeData TO CREATE THE NAVIGATION BUTTONS FOR THE SCROLL PANEL
    Private Sub CreateButtons()
        For i = 0 To bikeData.Count - 1
            ' Do the following code 0 to bikeData.Count - 1 times (until i = bikeData.Count)

            'Debug.WriteLine(bikeData(i)(0))

            Dim button As New Button
            ' creates a new button with the identifier 'button'
            button.Width = 200
            ' this sets the buttons width to 200 pixels
            button.Height = 60
            ' this sets the buttons height to 60 pixels
            button.Location = New Point(20, i * 65 + 20)
            ' this sets the buttons position, x = 20, y = (i * 65) + 20 
            button.Text = bikeData(i)(0)
            'the text given to the button, in this case (i) being the row and (0) being the collumn of the array bikeData
            button.Tag = i
            ' sets button tag to i, which in this case is the 
            button.Visible = True
            'sets the buttons visability to true, meaning the button will be visable 
            button.Font = New Font(button.Font.FontFamily, 16.0F, button.Font.Style)
            ' Changed the font settings to increase the size to 16.0F
            Panel.Controls.Add(button)
            ' After creating all the button settings it will be added to the panel 
            AddHandler button.Click, AddressOf Me.Button_Click
            ' when the button is clicked it will call the Button_Click sub routine
        Next
        ' increment i (i = i +1)

    End Sub ' End Sub-routine

    ' THIS PRIVATE SUB-ROUTINE BikeDiagram_Click, CALCULATES THE POSITION OF THE CLICK TO SEE IF IT IS INSIDE THE COORDINATES OF ANY
    ' ITEM IN ARRAY polygonList, BY CALLING THE isPointInsidePolygon SUB-ROUNINE
    ' IF THE CLICK IS INSIDE THE POLYGON COORDINATES IT WILL CALL THE SUB-ROUTINE loadDataForButtonIndex TO DISPLAY DATA FROM bikeData 
    ' IN RELATION TO i
    Private Sub BikeDiagram_Click(sender As Object, e As EventArgs) Handles BikeDiagram.Click
        Dim eMouse As MouseEventArgs = e
        ' Declare eMouse as click position of mouse click
        Dim pointA As New Point
        'Declare point as new cooridnate point
        pointA.X = eMouse.X
        ' X value of pointA = the X value of eMouse  
        pointA.Y = eMouse.Y
        ' Y value of pointA = the Y value of eMouse
        For i = 0 To polygonList.Count - 1
            ' Do the following code 0 to polygonList.Count - 1 times  (until i = polygonList.Count)
            Dim result As Boolean = isPointInsidePolygon(pointA, polygonList(i))
            ' Declare variable result as Boolean
            'result = isPointInsidePolygon(pointA, polygonList(i)) - (Calling the isPointInsidePolygon function)

            If result = True Then
                'If the return value from funciton = True the the following code will execute

                'Debug.Write("Result is True for polygon ")
                'Debug.WriteLine(i)
                loadDataForIndex(i)
                ' Call loadDataForButtonIndex sub-rountine using i as the parameter

            End If
            ' End 'If' statement
        Next
        ' increment i (i = i +1)

    End Sub
    ' End Sub-routine

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        HelpInformation.Show()
    End Sub
End Class ' End Class
