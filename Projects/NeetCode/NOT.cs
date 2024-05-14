 bool ContainsDuplicate(int[] nums)
{
    bool result = false;

    for (int i = 0; i < nums.Length; i++) 
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (j == i) continue;

            if (nums[i] == nums[j])
                return true;
        }
    
    }


    return result;


}


bool answer = ContainsDuplicate([1,2,3,4]);

Console.WriteLine(answer);

