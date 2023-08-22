/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
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
