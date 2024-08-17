// Class representing Me

class GiliMenahem {

    age = 29
    Hunger = 5
    booksRead = 10
    Creativity = 8
    JobSatisfaction = 7
    tiredness = 20
    muscles = 5

    // Method to grow older by 1 year, in case of birthday
    // If called, age will be itself + 1
    GrowUp() {
        age = age++
    }

    // Method to eat cookies, decreasing hunger
    // If called, hanger will decrease only if it is larger than 0, by the number of cookies eaten
    EatCookies(numberOfCookies) {
        if (Hunger > 0)
        Hunger -= numberOfCookies
    }

    // Method to read books, increasing number of read books
    // In case the book was not completed, dnf the book
    // The methods accepts the number of read pages and compared them to the number of pages in the book (also a parameter)
    ReadBooks(numberOfPages = 1, pagesInBook) {
        if (numberOfPages == pagesInBook)
       booksRead++
       else
       dnf; (did not finish in book terminology)
    }

    // Method to write code, increasing job satisfaction and tiredness
    // the method accepts hours spent coding, increase the job satisfaction in the amount of hours provided divided by two and increase tiredness by multiplying hours spent with the already existing tiredness, is tiredness = 0 tiredness will be equal to hoursSpent
    WriteCode(hoursSpent) {
        JobSatisfaction += hoursSpent / 2
        tiredness = tiredness * hoursSpent
        if (tiredness == 0)
        tiredness = hoursSpent
    }

    // Method to increase muscles by working out, increasing tiredness as well.
    // The mthod accepts hoursSpent on working out and increase the muscles by 0.1 the number of hoursSpent, and increase tiredness by multiplying hours spent with the already existing tiredness, is tiredness = 0 tiredness will be equal to hoursSpent
    workOut(hoursSpent) {
        tiredness = tiredness * hoursSpent
        muscles = muscles * hoursSpent * 0.1
        if (tiredness == 0)
        tiredness = hoursSpent
    }

    // Method to lower tiredness
    // This method accepts hoursSpent sleeping and lowers the tirdness by that amount, becuase tirdness cannot bt nagetive, it cannot be lower than 0 and the wakeUp method is called (not written here)

    sleep(hoursSpent) {
        for (let i = 0; i < hoursSpent; i++) {
            tiredness--
            if (tiredness == 0)
            wakeUp()
            break;
        }
    }

}
