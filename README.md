# PassValidator

Suppose we have a text file that looks like this:
a 1-5: abcdj
z 2-4: asfalseiruqwo
b 3-6: bhhkkbbjjjb

Each line consists of a password requirement and the password itself.
The password requirement specifies the character that the password must contain and how many times it must occur.
For example, the requirement in the first line means that the character "a" must occur between 1 and 5 times.
In the example above, two passwords are valid (1 and 3) because they satisfy their requirements, the 2nd is not, because the character "z" in it should occur 2 to 4 times, but never occurs.
You need to write code that will count the number of valid passwords in such a file.
