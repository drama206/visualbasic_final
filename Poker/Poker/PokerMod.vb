﻿Option Explicit On
Option Strict On

'----------------------------------------------------------------------------------------- 
'Program Module:     PokerMod
'Author:             Mark D. Ingham and Kevin Kwok
'Date:               June 6, 2017
'Description:        Module contains score logic, defined poker hands, and array sorting algorithm.
'-------------------------------------------------------------------------------------------------  

Module PokerMod
    Public Const strCLUBS As String = "Clubs"
    Public Const strSPADES As String = "Spades"
    Public Const strHEARTS As String = "Hearts"
    Public Const strDIAMONDS As String = "Diamonds"
    Public rand As New Random
    Public intSuit(51) As Integer 'Array contains card suits
    Public intCardNo(51) As Integer 'Array contains card values
    Public picCardArray(4) As PictureBox 'Contains 5 PictureBox elements
    Public imgCardArray(51) As Image 'Contains 52 Image elements
    Public blnHold(4) As Boolean 'Allows user to hold onto cards from picCardArray()
    Public blnCardDealt(51) As Boolean 'Prevents duplicate card from arising, needs to ensure cards are randomly generated by using a loop
    Public intHand(4) As Integer 'Array contains the cards currently in the player's hand 
    Public intScore As Integer 'Used for determining the score of the player's hand
    Public strScore As String 'Used for outputing the corresponding string of the score
    Public intScoreTotal As Integer 'Used for counting up the score total after each hand is played
    Sub BubbleSort()
        '----------------------------------------------------------------------------------------- 
        'Subroutine:     BubbleSort()
        'Author:         Mark D. Ingham
        'Date:           May 31, 2017
        'Description:    Algorithm sorts the cards in the player's hand after btnDraw is clicked.
        '                The algorithm compares between lower (2) and upper-bound (14) values in the hand,
        '                and sorts accordingly from left to right, lowest to highest.
        '-------------------------------------------------------------------------------------------------

        'Sorts an array using bubble sort algorithm
        Dim i As Integer, j As Integer
        Dim Temp As Integer

        For i = 0 To 3
            For j = (i + 1) To 4

                If intCardNo(intHand(i)) > intCardNo(intHand(j)) Then
                    Temp = intHand(j)
                    intHand(j) = intHand(i)
                    intHand(i) = Temp
                End If
            Next j
        Next i
    End Sub
    Sub Score(ByRef intScore As Integer, ByRef strOutput As String)
        '----------------------------------------------------------------------------------------- 
        'Subroutine:     Score()
        'Author:         Mark D. Ingham
        'Date:           June 1, 2017
        'Description:    Contains all possible hands that can be scored in this poker game.
        '                Compares player's hand against every combination listed below, and select the highest scoring tier.
        '-------------------------------------------------------------------------------------------------

        'Score is initialized to nothing, and then calls on BubbleSort() to sort the hand before scoring comparision commences
        intScore = 0
        Call BubbleSort()

        'Score defaults to HighCardScore(), before further comparison begins
        strOutput = "High Card"
        intScore = HighCardScore()

        'If the player's highest card is less than a Jack, then it is worthless
        If intScore = 0 Then
            strOutput = "Worthless"
        End If

        'Checks for one pair
        If IsOnePair() Then
            intScore = 20
            strOutput = "One Pair"
        End If

        'Checks for two pairs
        If IsTwoPair() Then
            intScore = 30
            strOutput = "Two Pairs"
        End If

        'Checks for a triple
        If IsTriple() Then
            intScore = 40
            strOutput = "Triple"
        End If

        'Checks for a straight
        If IsStraight() Then
            intScore = 50
            strOutput = "Straight"
        End If

        'Checks for a flush
        If IsFlush() Then
            intScore = 60
            strOutput = "Flush"
        End If

        'Checks for a full house
        If IsFullHouse() Then
            intScore = 70
            strOutput = "Full House"
        End If

        'Checks for a four of a kind
        If IsFourOfAKind() Then
            intScore = 80
            strOutput = "Four of a Kind"
        End If

        'Checks for a straight and a flush
        If IsFlush() And IsStraight() Then
            intScore = 90
            strOutput = "Straight Flush"
            'Checks for a straight and flush combination, and then checks if an ace is the highest card present
            If intCardNo(intHand(4)) = 14 Then
                intScore = 100
                strOutput = "Royal Flush"
                'Checks for a 2 as the lowest card if an ace is the highest card
                If intCardNo(intHand(0)) = 2 Then
                    intScore = 100
                    strOutput = "Five-High Straight Flush"
                End If
            End If
        End If

        'The numeric value of each applicable poker combination (from each game played) is added to a counter
        intScoreTotal = intScoreTotal + intScore
    End Sub
    Function HighCardScore() As Integer
        '----------------------------------------------------------------------------------------- 
        'Function:     HighCardScore()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Default highest scoring hand that is returned to the player.
        '              Any hand that has a value greater than 10 will have a value returned, 
        '              meaning Jacks, Queens, Kings and Aces.
        '-------------------------------------------------------------------------------------------------

        Dim intHighScore As Integer
        If intCardNo(intHand(4)) > 10 Then
            intHighScore = intCardNo(intHand(4))
        Else
        End If
        Return intHighScore
    End Function
    Function IsOnePair() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsOnePair()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has one pair.
        '-------------------------------------------------------------------------------------------------

        Dim blnFoundOnePair As Boolean
        For intX = 0 To 3
            For intY = intX + 1 To 4
                If intCardNo(intHand(intX)) = intCardNo(intHand(intY)) Then
                    blnFoundOnePair = True
                End If
            Next
        Next
        Return blnFoundOnePair
    End Function
    Function IsTwoPair() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsTwoPair()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has two pairs.
        '-------------------------------------------------------------------------------------------------

        Dim blnFoundTwoPair As Boolean
        If intCardNo(intHand(0)) = intCardNo(intHand(1)) Then
            'Found 1 pair including 1st card
            If intCardNo(intHand(2)) = intCardNo(intHand(3)) Then
                '3rd and 4th card are a pair
                blnFoundTwoPair = True
            ElseIf intCardNo(intHand(3)) = intCardNo(intHand(4)) Then
                '4th and 5th card are a pair
                blnFoundTwoPair = True

            End If
        ElseIf intCardNo(intHand(1)) = intCardNo(intHand(2)) Then
            'Found 1 pair skipping first card ie card 2 and 3
            If intCardNo(intHand(3)) = intCardNo(intHand(4)) Then
                'Found 4th and 5th card are a pair
                blnFoundTwoPair = True
            End If
        End If
        Return blnFoundTwoPair
    End Function
    Function IsTriple() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsTriple()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has a triple/three of a kind.
        '-------------------------------------------------------------------------------------------------

        Dim blnFoundTriple As Boolean
        For intX = 0 To 2
            For intY = intX + 1 To 4
                If intCardNo(intHand(intX)) = intCardNo(intHand(intY)) Then
                    For intZ = intY + 1 To 4
                        If intCardNo(intHand(intY)) = intCardNo(intHand(intZ)) Then
                            blnFoundTriple = True
                        End If
                    Next

                End If
            Next
        Next
        Return blnFoundTriple
    End Function
    Function IsStraight() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsStraight()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has a straight.
        '              Conditionally, it also checks if the player has an ace, 
        '              and will score a low-straight (Ace to Five) or high-straight (Ten to Ace) if applicable.
        '-------------------------------------------------------------------------------------------------

        Dim blnStraight As Boolean
        Dim blnChangeBack As Boolean

        'Checks to see if the player's lowest-value card is a 2, and then will check for an ace, change its value to 1, and re-sort the hand
        If intCardNo(intHand(0)) = 2 Then
            If intCardNo(intHand(4)) = 14 Then
                blnChangeBack = True
                intCardNo(intHand(4)) = 1
                Call BubbleSort()
            End If
        End If

        'If the lowest-value card has the next highest card next to it, and so forth, a straight is scored
        If intCardNo(intHand(0)) + 1 = intCardNo(intHand(1)) Then
            blnStraight = True
            For intX = 1 To 3
                If intCardNo(intHand(intX)) + 1 <> intCardNo(intHand(intX + 1)) Then
                    blnStraight = False
                End If
            Next
        End If

        'This will revert the value of aces to 14
        If blnChangeBack = True Then
            intCardNo(intHand(0)) = 14
            Call BubbleSort()
        End If
        Return blnStraight
    End Function
    Function IsFlush() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsFlush()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has a flush/all cards are the same suit.
        '-------------------------------------------------------------------------------------------------

        Dim blnFoundFlush As Boolean
        If intSuit(intHand(0)) = intSuit(intHand(1)) Then
            blnFoundFlush = True
            For intX = 1 To 3
                If intSuit(intHand(intX)) <> intSuit(intHand(intX + 1)) Then
                    blnFoundFlush = False
                End If
            Next
        End If
        Return blnFoundFlush
    End Function
    Function IsFullHouse() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsFullHouse()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has both one pair and a triplet.
        '-------------------------------------------------------------------------------------------------

        Dim blnFoundFull As Boolean
        If intCardNo(intHand(0)) = intCardNo(intHand(1)) Then
            'Found 1 pair including 1st card
            If intCardNo(intHand(2)) = intCardNo(intHand(3)) And intCardNo(intHand(2)) = intCardNo(intHand(4)) Then
                '3rd and 4th and 5th are triple
                blnFoundFull = True
            End If
        ElseIf intCardNo(intHand(0)) = intCardNo(intHand(1)) And intCardNo(intHand(1)) = intCardNo(intHand(2)) Then
            'Found triple in 1st 3 cards
            If intCardNo(intHand(3)) = intCardNo(intHand(4)) Then
                'Found 4th and 5th card are a pair
                blnFoundFull = True
            End If
        End If
        Return blnFoundFull
    End Function
    Function IsFourOfAKind() As Boolean
        '----------------------------------------------------------------------------------------- 
        'Function:     IsFourOfAKind()
        'Author:       Mark D. Ingham
        'Date:         June 1, 2017
        'Description:  Checks to see if the player has a four of a kind.
        '-------------------------------------------------------------------------------------------------

        Dim blnIsFour As Boolean
        For intX = 0 To 1
            For intY = intX + 1 To 4
                If intCardNo(intHand(intX)) = intCardNo(intHand(intY)) Then
                    For intZ = intY + 1 To 4
                        If intCardNo(intHand(intY)) = intCardNo(intHand(intZ)) Then
                            For intW = intZ + 1 To 4
                                If intCardNo(intHand(intZ)) = intCardNo(intHand(intW)) Then
                                    blnIsFour = True
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next
        Return blnIsFour
    End Function
End Module
