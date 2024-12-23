public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0, start = 0, end = height.Length - 1;
        while(start < end)
        {
            // maxArea is maximum of the current area and the overall maxArea
            maxArea = int.Max(maxArea, (end - start) * int.Min(height[start], height[end]));

            // using 2 pointer approach
            // whichever pointer points to smaller height, move it closer to other
            if(height[start] >= height[end])
            {
                end--;
            } else {
                start++;
            }
        }
        return maxArea;
    }
}
