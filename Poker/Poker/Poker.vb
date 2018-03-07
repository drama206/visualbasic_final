Option Explicit On
Option Strict On

'----------------------------------------------------------------------------------------- 
'Program:   Lab 4 – Poker
'Author:      Mark D. Ingham and Kevin Kwok
'Date:        June 7, 2017
'Description: Program allows users to play poker, hold cards, draw hands, 
'             have their hands calculated With a running total score counter. 
'-------------------------------------------------------------------------------------------------  

Public Class frmPoker

    Private Sub frmPoker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  frmPoker_Load
        'Author:      Kevin Kwok
        'Date:        June 1, 2017 
        'Description: Loads several subroutines into memory, including pictures, suit, and card number arrays.
        '-------------------------------------------------------------------------------------------------

        'Initialize subroutines before starting the game
        Randomize()
        LoadSuittoPictureBoxes()
        SetPictureBoxArray()
        AugmentedAces()

    End Sub

    Sub SetPictureBoxArray()
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  SetPictureBoxArray()
        'Author:      Kevin Kwok
        'Date:        June 1, 2017 
        'Description: Assigns picCardArray() to their appropriate PictureBoxes.
        '-------------------------------------------------------------------------------------------------

        'Equates each element of the picCardArray with the 5 physical PictureBoxes
        picCardArray(0) = picCard1
        picCardArray(1) = picCard2
        picCardArray(2) = picCard3
        picCardArray(3) = picCard4
        picCardArray(4) = picCard5

    End Sub

    Sub LoadSuitToPictureBoxes()
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  LoadSuitToPictureBoxes()
        'Author:      Mark D. Ingham (much stolen from Penny)
        'Date:        May 30, 2017 
        'Description: In this subroutine, the imgCardArray that loads all card images into memory is defined,
        '             as well as the limits of the arrays that will hold the card suits and card numbers.
        '-------------------------------------------------------------------------------------------------

        Dim intSuitX As Integer
        Dim intCardInSuit As Integer
        Dim strSuit As String
        'Load card images into the imgCardArray
        For intX = 0 To imgCardArray.Length - 1
            intCardInSuit += 1

            'Change suits and reset card number to 1 after every 13 cards
            Select Case intX
                Case 0
                    intSuitX = 0
                    intCardInSuit = 1
                    strSuit = strCLUBS
                Case 13
                    intSuitX = 1
                    intCardInSuit = 1
                    strSuit = strSPADES
                Case 26
                    intSuitX = 2
                    intCardInSuit = 1
                    strSuit = strHEARTS
                Case 39
                    intSuitX = 3
                    intCardInSuit = 1
                    strSuit = strDIAMONDS
            End Select

            'imgCardArray now defined, and will retrieve appropriate images corresponding to the number and suit
            imgCardArray(intX) = Image.FromFile("..\ImagesSmall\" & intCardInSuit.ToString & "_" & strSuit & ".jpeg")

            'Suit and card number arrays defined
            intSuit(intX) = intSuitX
            intCardNo(intX) = intCardInSuit
        Next
    End Sub

    Sub AugmentedAces()
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  AugmentedAces()
        'Author:      Mark D. Ingham
        'Date:        June 6, 2017 
        'Description: The value of the ace card is increased to 14 across all four suits. 
        '             This is done to allow for scoring high straights involving the ace, as well as straight/royal flushes.
        '-------------------------------------------------------------------------------------------------

        'Increases value of aces, from the initial value of 1, all the way to 14
        'Step 13 allows the array to target the card numbers corresponding with the ace of each suit.
        For intX = 0 To 39 Step 13
            intCardNo(intX) = 14
        Next
    End Sub

    Function GetRandomCardNo() As Integer
        '----------------------------------------------------------------------------------------- 
        'Function:    GetRandomCardNo()
        'Author:      Mark D. Ingham and Kevin Kwok
        'Date:        May 30, 2017 
        'Description: This function prevents the same card in the hand from being drawn again, 
        '             or duplicated while the user is playing the same game.
        '-------------------------------------------------------------------------------------------------

        'Prevents duplicates from being drawn
        Dim intCardsDrawn As Integer

        'Dealing cards
        Do
            intCardsDrawn = rand.Next(52)
        Loop While blnCardDealt(intCardsDrawn) = True
        blnCardDealt(intCardsDrawn) = True

        'Returns value
        Return intCardsDrawn
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  btnStart_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Initiates the game by hiding btnStart, and revealing all the PictureBoxes and Buttons needed to play.
        '-------------------------------------------------------------------------------------------------

        'Conceals unneeded element.
        btnStart.Visible = False

        'Reveals neccessary interactive elements.
        picCard1.Visible = True
        picCard2.Visible = True
        picCard3.Visible = True
        picCard4.Visible = True
        picCard5.Visible = True
        btnHold1.Visible = True
        btnHold2.Visible = True
        btnHold3.Visible = True
        btnHold4.Visible = True
        btnHold5.Visible = True
        btnDraw.Visible = True

        'Retrieves the first set of cards the user will have in their starting hand
        For intX = 0 To 4
            intHand(intX) = GetRandomCardNo()
            picCardArray(intX).Image = imgCardArray(intHand(intX))
        Next
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  btnDraw_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: When the player is ready to proceed and commit their hand, btnDraw will replace any unwanted cards,
        '             hide unnecessary elements, calculate the hand's score, and proceed to output.
        '-------------------------------------------------------------------------------------------------

        'Shifts visibility for focal elements
        btnDraw.Visible = False
        btnRestart.Visible = True

        'Draws new cards for each unwanted card in the user's hand, by calling subroutines and arrays
        For intX = 0 To 4
            If blnHold(intX) = False Then
                intHand(intX) = GetRandomCardNo()
                picCardArray(intX).Image = imgCardArray(intHand(intX))
            End If
        Next

        'Disables hold buttons, and limits the user to play one game with two draws
        Me.btnHold1.Enabled = False
        Me.btnHold2.Enabled = False
        Me.btnHold3.Enabled = False
        Me.btnHold4.Enabled = False
        Me.btnHold5.Enabled = False

        'Calls subroutine to score hand, and output the scores to both a listbox and a label
        Score(intScore, strScore)
        MsgBox("Your hand is " & strScore & ", which is worth " & intScore & " points!")
        lstOutScore.Items.Add(strScore & " - " & intScore.ToString)
        lstOutScore.TopIndex = lstOutScore.Items.Count - 1
        lstOutScore.SelectedIndex += 1
        lblOutScore.Text = intScoreTotal.ToString
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        '----------------------------------------------------------------------------------------- 
        'Subroutine:  btnRestart_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: If the user wishes to begin a new game after concluding their first, btnRestart will 
        '             start a completely new game, and reset all game elements from the first playthrough.
        '             Doing so will allow the user to play several more iterations if desired,
        '             without exhausting the deck due to GetRandCardNo() subroutine to prevent duplicates.
        '-------------------------------------------------------------------------------------------------

        'Shifts visibility on focal emenets
        btnRestart.Visible = False
        btnDraw.Visible = True

        'Re-enables buttons and resets the backcolors for all buttons to default
        Me.btnHold1.Enabled = True
        Me.btnHold2.Enabled = True
        Me.btnHold3.Enabled = True
        Me.btnHold4.Enabled = True
        Me.btnHold5.Enabled = True
        btnHold1.BackColor = SystemColors.Control
        btnHold2.BackColor = SystemColors.Control
        btnHold3.BackColor = SystemColors.Control
        btnHold4.BackColor = SystemColors.Control
        btnHold5.BackColor = SystemColors.Control

        'Reset GetRandomCardNo() to prevent exhausting number of cards/whole deck from being drawn, and entering an infinite loop
        For intX = 0 To 51
            blnCardDealt(intX) = False
        Next

        'Retrieves a new set of cards the user will have in their starting hand
        For intX = 0 To 4
            blnHold(intX) = False
            intHand(intX) = GetRandomCardNo()
            picCardArray(intX).Image = imgCardArray(intHand(intX))
        Next
    End Sub

    Private Sub btnHold1_Click(sender As Object, e As EventArgs) Handles btnHold1.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnHold1_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Holds onto picCard1, and indicates that the card is being held by changing button color to aqua.
        '             Button color reverts back to default if user clicks the button a second time,
        '             indicating that they no longer wish to keep that card.
        '             Boolean status toggle may be repeated as liked.
        '-------------------------------------------------------------------------------------------------

        'Card will be held if button is clicked
        blnHold(0) = True

        'Saving the selected card with a toggle between Boolean values; corresponds with button backcolor change
        If btnHold1.BackColor = SystemColors.Control Then
            btnHold1.BackColor = Color.Aqua
        Else
            blnHold(0) = False
            btnHold1.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnHold2_Click(sender As Object, e As EventArgs) Handles btnHold2.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnHold2_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Holds onto picCard2, and indicates that the card is being held by changing button color to aqua.
        '             Button color reverts back to default if user clicks the button a second time,
        '             indicating that they no longer wish to keep that card.
        '             Boolean status toggle may be repeated as liked.
        '-------------------------------------------------------------------------------------------------

        'Card will be held if button is clicked
        blnHold(1) = True

        'Saving the selected card with a toggle between Boolean values; corresponds with button backcolor change
        If btnHold2.BackColor = SystemColors.Control Then
            btnHold2.BackColor = Color.Aqua
        Else
            blnHold(1) = False
            btnHold2.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnHold3_Click(sender As Object, e As EventArgs) Handles btnHold3.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnHold3_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Holds onto picCard3, and indicates that the card is being held by changing button color to aqua.
        '             Button color reverts back to default if user clicks the button a second time,
        '             indicating that they no longer wish to keep that card.
        '             Boolean status toggle may be repeated as liked.
        '-------------------------------------------------------------------------------------------------

        'Card will be held if button is clicked
        blnHold(2) = True

        'Saving the selected card with a toggle between Boolean values; corresponds with button backcolor change
        If btnHold3.BackColor = SystemColors.Control Then
            btnHold3.BackColor = Color.Aqua
        Else
            blnHold(2) = False
            btnHold3.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnHold4_Click(sender As Object, e As EventArgs) Handles btnHold4.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnHold4_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Holds onto picCard4, and indicates that the card is being held by changing button color to aqua.
        '             Button color reverts back to default if user clicks the button a second time,
        '             indicating that they no longer wish to keep that card.
        '             Boolean status toggle may be repeated as liked.
        '-------------------------------------------------------------------------------------------------

        'Card will be held if button is clicked
        blnHold(3) = True

        'Saving the selected card with a toggle between Boolean values; corresponds with button backcolor change
        If btnHold4.BackColor = SystemColors.Control Then
            btnHold4.BackColor = Color.Aqua
        Else
            blnHold(3) = False
            btnHold4.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnHold5_Click(sender As Object, e As EventArgs) Handles btnHold5.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnHold5_Click
        'Author:      Kevin Kwok
        'Date:        June 2, 2017 
        'Description: Holds onto picCard5, and indicates that the card is being held by changing button color to aqua.
        '             Button color reverts back to default if user clicks the button a second time,
        '             indicating that they no longer wish to keep that card.
        '             Boolean status toggle may be repeated as liked.
        '-------------------------------------------------------------------------------------------------

        'Card will be held if button is clicked
        blnHold(4) = True

        'Saving the selected card with a toggle between Boolean values; corresponds with button backcolor change
        If btnHold5.BackColor = SystemColors.Control Then
            btnHold5.BackColor = Color.Aqua
        Else
            blnHold(4) = False
            btnHold5.BackColor = SystemColors.Control
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '-----------------------------------------------------------------------------------------
        'Subroutine:  btnExit_Click
        'Author:      Kevin Kwok
        'Date:        May 30, 2017 
        'Description: Terminates the application when clicked.
        '-------------------------------------------------------------------------------------------------

        'Terminates application with a friendly MessageBox pop-up
        MsgBox("Thanks for playing poker!")
        Me.Close()
    End Sub
End Class
