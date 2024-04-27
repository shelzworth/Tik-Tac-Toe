# Tik-Tac-Toe
Tik Tac Toe Application

This is another one of my senior high school projects, to create a tic tac toe application. The objective of this project was to create a working tic tac toe game application, the theme once again was up to the designer granted it was appropriate. This one was themed after Fortnite and Tilted Towers solely for the amusement of my instructor and peers. This application was designed before connect-4 and was a project the instructor used to build up and refresh our knowledge on variables, arrays and user-object interaction events. 
The Program Works as Follows:
 - Initializing an empty array with 9 elements acting as the board.
 - Initializing two boolean variables for each player win and setting them as false.
 - A turn variable is initialized and increases by 1 every time a picture box is clicked.
 - To distinguish whose turn it is if the turn variable is odd it's player 1s turn and if its even its player 2's turn.
 - Each player will go back and forth placing their respective markers on the board until one player gets three in a row or all spots are exhausted.
 - Once one of the two occur a textbox with the winner or no winners will appear and a retry(replay) button will appear.
   
The development process taught me some important things. The first and most noticeable was to loop music so that when the application is open the music does not just cut off and remain silent the rest of the time.
Another idea I came up with was adding randomized turns to make the game more dynamic which I ended up doing later on in the connect 4 game. However I refrained for this since usually in tic tac toe X always goes first and O always goes second so randomizing doesn't make much sense. Another lesson I learned was not to manually make each scenario, this proved to be extremely time consuming and inefficient. This was also resolved in the connect 4 application with the use of loops to check the vertical and horizontal cases which would have been very useful for this application.

Initialization

The application initializes an array which acts as the board with each element being a spot in the board. The turn variable is initialized and set to 0. Two boolean variables are made for each player's win scenario which by default are set to false only being true if one of the players wins. Another variable pbPicked is also initialized which was for the selected picture box.

pickedbox()

The turn is increased by 1. The picked picture box is the one that sends the you to this function, the picked box is then disabled preventing anymore clicking in that box and the picked picture box's name is a string that is placed into a character array. Since the name of each picturebox follows the naming convention "picturebox0" to "picturebox8" the index of interest is index 10 which is the one containing the number. The 10th index of the character array is then parsed and placed into the pbPicked variable. Using a switch-case and modulus system, the image of the picturebox picked.Image is set to the respective player's image. Then board[pbPicked] is set to the string according to the player who has taken the space. Finally the function whosethewinner() is executed after each turn to check if any player has won the game.

whosethewinner()

This function consists of 17 possible scenarios 8 for each player checking if there are three in a row horizontally, vertically or diagonally across the board and displaying a message box with the winner announced if there is and enabling and making visible the retry button. The last scenario is for the case where no combination is made from either side and there is no winner which is when turns exceed 9, the message box displays "The battle rages on!" and allows players to restart.

Form1_Load()

Hides the retry button when the application loads and plays the background music.

BtnRetry_Click()

Restarts the application in the event that the retry button is clicked.

btnExit_Click()

Exits the application in the event that the exit button is clicked.


