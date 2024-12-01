# Purpose of this project

This is a project I built using C# and .NET framework. I took the provided list of Advertisement companies located in the TextFiles folder and had them be compared using a threshold. Overall what it does is check the threshold, 
which checks for how similar a company is with every company in the list, and then writes it to the console letting the user see which companies are being compared, as well as how similar they are. 

# What would I do if I had more time?

If given more time to work on this project, I'd want to make a few different changes. 

* First, I'd want to integrate SQL Server with my project, as it would have allowed me to store the data that's being returned into a 
  table so that I could track my results more efficiently. It would have also allowed for me to use various queries for filtering, sorting, and managing the company names to make it more organized and readable. 

* Next, I would have also wanted to continue optimizing the performance of my project. It's still taking a bit of time to execute even after I using async/await in my project. However, this was my first time using FuzzySharp 
  for doing comparing the company names, as well as scoring them based on how similar they were. If I had more time, I would've looked to see if that was the most optimal route to take, as well as if there are 
  ways to improve the execution time for the utilities I was using from the FuzzySharp NuGet package.

* Additionally, I would have done more research on how to accomplish this task in the most efficient way. A problem I'm noticing with my project is that if the name of the company is very similar, but 1 letter is different, it will
  return the data as being a match. While that may be for some cases, it's not for a lot of them also. For example, if the company Washington Lottery was being compared with a company called Washington Pottery, then my project would 
  return these companies as being a close match. However, they're very different, as you can see:

  Washington Lottery
  Washington Pottery

  Very similar company names, but still very different. This is something I'd need to either refine, or possibly even look at other ways to accomplish my goal. Either way, I would need a way to fix this issue so that we wouldn't get
  too many matches that are similar, but also very different.

* Lastly, I would have also added more error handling + logging. Since this is a smaller project that I didn't spend more than an hour on, my primary focus was just getting the data to return in a readable way that'd accomplish 
  my task. However, in doing so, I did very minimal error handling, which would cause problems in a large scale system. I typically will always use Try-Catch error handling in order to keep my project from breaking anything, 
  while also logging what's occurring so that I'm aware of when my projects are running into issues. It's a safe way to track your project without breaking other projects held within the same system.

# Closing Summary 

Overall, this was a fun little project to work on and I enjoyed being able to come to an acceptable solution in a short time. I definitely would prefer more time, but I'm also content with what I came up with in that time. I hope
you enjoy the solution I was able to come up with!
