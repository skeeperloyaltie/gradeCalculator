Public Class GradePointCalculator
    Dim gpa_decimal As Decimal
    Dim TotalofGrade As Integer
    Dim TotalofCreditHour As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gradeValue As String = TextBox1.Text
        Dim creditHourValue As Integer

        Select Case gradeValue
            Case "A"
                TotalofGrade += 4 * Integer.TryParse(TextBox2.Text, creditHourValue)
            Case "B"
                TotalofGrade += 3 * Integer.TryParse(TextBox2.Text, creditHourValue)
            Case "C"
                TotalofGrade += 2 * Integer.TryParse(TextBox2.Text, creditHourValue)
            Case "D"
                TotalofGrade += 1 * Integer.TryParse(TextBox2.Text, creditHourValue)
            Case "F"
                TotalofGrade += 0 * Integer.TryParse(TextBox2.Text, creditHourValue)
            Case Else
                MessageBox.Show("Invalid Grade Entered.")
        End Select

        TotalofCreditHour += creditHourValue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TotalofCreditHour <> 0 Then
            gpa_decimal = TotalofGrade / TotalofCreditHour
            TextBox3.Text = gpa_decimal.ToString("N2")
        Else
            MessageBox.Show("No credit hour entered.")
        End If
    End Sub
End Class
