Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        If IsNumeric(txtSideOne.Text) = True And IsNumeric(txtSideTwo.Text) = True Then
            txtHyp.Text = hypotenuse(CDbl(txtSideOne.Text), CDbl(txtSideTwo.Text))
        Else
            MessageBox.Show("Please enter in valid values")
        End If

    End Sub

    Function hypotenuse(ByVal sideOne As Double, ByVal sideTwo As Double) As String
        Return CStr(Math.Sqrt(Math.Pow(CDbl(txtSideOne.Text), 2.0) + Math.Pow(CDbl(txtSideTwo.Text), 2.0)))
    End Function

End Class
