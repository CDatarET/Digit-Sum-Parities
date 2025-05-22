# Digit-Sum-Parities
CodeChef Difficulty 1077 Problem

Digit Sum Parities
Problem Description
For a positive integer M, MoEngage defines digitSum(M) as the sum of digits of the number M (when written in decimal).

For example:

Copy
Edit
digitSum(1023) = 1 + 0 + 2 + 3 = 6
Given a positive integer N, find the smallest integer X strictly greater than N such that:

digitSum(N) and digitSum(X) have different parity — that is, one of them is odd and the other is even.

Input Format
The first line contains an integer T, the number of test cases.

Each of the next T lines contains a single integer N.

Output Format
For each test case, print a single line containing the value of X, the smallest integer greater than N for which the parity of digitSum(N) and digitSum(X) is different.

Example
Input
Copy
Edit
2
12
13
Output
Copy
Edit
14
15
Explanation
For N = 12, digitSum(12) = 1 + 2 = 3 (odd). The next number X = 14 has digitSum(14) = 1 + 4 = 5 (also odd), so continue. At X = 15, digitSum(15) = 6 (even), so we stop.
But wait — the correct answer in this example should actually be 13, since digitSum(13) = 4, which is even.

Rewriting the correct output:

Corrected Example
Input
Copy
Edit
2
12
13
Output
Copy
Edit
13
14
