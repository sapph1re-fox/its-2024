# How to use this repository

How to git
How to have git on your PC
Commiting


### How to change my default text editor to VIM
Open file /home/its/.bashrc

 `code /home/its/.bashrc`

Add at the end of the file

``# Default text editor
export EDITOR=vi``

and save.


## I want to have local copy of this repository on my PC


## I want to publish my code
1. Pull anu changes

    `git pull`

2. Create new branch in terminal
    
    `git checkout -b name-of-my-new-branch`

naming tip - use your name and date, use dashes insted of spaces, not capitalised letters


3. Add folder with your name
4. Write your code solution inside of you folder
5. Navigate in terminal in the its-2024 folder
    pwd - command that shows where you are
    cd - command to navigate about folders
6. Run command in your terminal
    git status
    to see the files you changed.
7. Add files to be commited.
    git add name-of-the-file

    or

    git add .

    to add all the files that were changed.
    Note: use this only if you are sure of changes you made.
8. Commit your code.

    git commit -m "Write your commit message here"
    git commit
    -you will be prompted to a text editor to wrte your message

9. Push your changes to remote repository

    `git push`

10. Go to github in your browser and open pull request.

