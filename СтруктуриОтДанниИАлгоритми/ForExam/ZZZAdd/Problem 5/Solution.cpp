#include <iostream>
#include <queue>
#define MAXN 100000
#define WHEELS 5
using namespace std;
int startPosition, finalPosition;
bool forbiddenCombinations[MAXN];
bool used[MAXN];
int powerOf10[WHEELS];

int solve()
{
    queue<int> nodes;
    int level = 0;

    nodes.push(startPosition);
    while(!nodes.empty())
    {
        queue<int> nextLevelNodes;
        level++;
        while(!nodes.empty())
        {
            int node = nodes.front();
            nodes.pop();
            if (node == finalPosition) return level - 1;

            // Pressing the left button
            for (int i = 0; i < WHEELS; i++)
            {
                int newNode = node;
                int digit = (node / powerOf10[i]) % 10;
                if (digit == 9)
                {
                    newNode -= 9 * powerOf10[i];
                }
                else
                {
                    newNode += powerOf10[i];
                }
                if (used[newNode]) continue;
                if (forbiddenCombinations[newNode]) continue;
                used[newNode] = true;
                nextLevelNodes.push(newNode);
            }

            // Pressing the right button
            for (int i = 0; i < WHEELS; i++)
            {
                int newNode = node;
                int digit = (node / powerOf10[i]) % 10;
                if (digit == 0)
                {
                    newNode += 9 * powerOf10[i];
                }
                else
                {
                    newNode -= powerOf10[i];
                }
                if (used[newNode]) continue;
                if (forbiddenCombinations[newNode]) continue;
                used[newNode] = true;
                nextLevelNodes.push(newNode);
            }
        }
        nodes = nextLevelNodes;
    }

    return -1;
}

int main()
{
    // Read input
    cin >> startPosition >> finalPosition;
    int forbiddenCombinationsCount;
    cin >> forbiddenCombinationsCount;
    for(int i = 0; i < forbiddenCombinationsCount; i++)
    {
        int forbiddenCombination;
        cin >> forbiddenCombination;
        forbiddenCombinations[forbiddenCombination] = true;
    }

    // Prepare
    powerOf10[0] = 1;
    for (int i = 1; i < WHEELS; i++)
    {
        powerOf10[i] = powerOf10[i - 1] * 10;
    }

    // Solve
    int solution = solve();

    // Output solution
    cout << solution << endl;
}
