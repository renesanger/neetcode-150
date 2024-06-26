/*
    242. Valid Anagram
    Level: easy
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    Example 1:
    
    Input: s = "anagram", t = "nagaram"
    Output: true
 */
var isAnagram = function(s, t) {
    if(s.length != t.length)
        return false;

    var freq = {};
    var result = true;
    [...s].forEach((c)=> {
        if(!(c in freq))
        {
            freq[c]=1
        }
        else
        {
            freq[c]+=1;
        }
    });
    for (const [key, value] of Object.entries(freq)) {
        console.log(key, value);
    }

    [...t].forEach((c) => {
        if(c in freq && freq[c]>0)
        {
            freq[c]-=1;
        }
        else{
            result = false;
        }
    })

    return result;
};
