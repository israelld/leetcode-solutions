public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
int moves = 0;
int current;

for(int i = 0; i < seats.Length; i++)
{
    for (int j = i; j < seats.Length; j++)
    {
        if(seats[i] > seats[j])
        {
            current = seats[j];
            seats[j] = seats[i];
            seats[i] = current;
        }
    }
}

for (int i = 0; i < students.Length; i++)
{
    for (int j = i; j < students.Length; j++)
    {
        if (students[i] > students[j])
        {
            current = students[j];
            students[j] = students[i];
            students[i] = current;
        }
    }
}

for (int i = 0; i < students.Length; i++)
{
    if (students[i] > seats[i])
    {
        moves += students[i] - seats[i];
    }
    else if (students[i] < seats[i])
    {
        moves += seats[i] - students[i];
    }
}
        return moves;
    }
}