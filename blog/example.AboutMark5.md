title: Example: About Mark5

About Mark5
===========

Mark5 is a Google Chrome extension that makes markdown reading nice and simple.
&copy;&nbsp;2012&nbsp;Dmitriy&nbsp;Komarov  


> One day I was working with a bunch of github projects, each having a few .md files, and realized
> that there was no application on my box that could show them in a nicely rendered way.
> Well, since there are javascript converters that would render markdown into HTML, why not use them
> Google Chrome to handle this? That's how Mark5 was created (don't ask me why it's '5' and where are the previous 4).
>
> P.S. OK, the next day I've googled a bit and found out that there are extensions doing exactly the same thing,
> but it was too late - Mark5 was out there.



First Time Setup
----------------

Mark5 works with internet markdown files, though its primary goal was to nicely render the local .md|.markdown texts.
Local files rendering requires some configuration. To enable it please do the following:

1. open Options&nbsp;&gt;&nbsp;<a id="mark5_extensions" href="#">Extensions</a>
2. click on the triangle to the left from Mark5 section to expand it
3. tick "Allow access to file URLs"  

![](images/aboutmark5/checkthis.png)  



Functionality
-------------

Mark5 shows markdown files. That's pretty much it, although here are few tips that might be useful.

1. How it works

	Mark5 checks open file address and re-renders the page if extension matches '.md', '.mdown', '.markdown', or '.mkdn*'.  

2. Sidebar buttons

	![](images/aboutmark5/return.png) Right now, the "back" button (shortcut: Esc)
	will close "About Mark5" page and bring back the file that you were looking at. One more click will show the original unformatted text.
	If you want to re-render markdow at that point - just refresh the page (F5).

	![](cimages/aboutmark5/gear.png) Configuration popup gives an option of choosing from
	4 themes (light and dark, serif and sans-serif) and 4 font sizes to adjust the page to your liking.
	Mark5 will remember the settings and use them for all markdown files.
	You can try changing themes or font size right now, it works on this page too.  

	![](images/aboutmark5/about.png) "Info-cube" button opens this "About Mark5" page.

3. Print

	- When printing Mark5 hides the sidebar and adds a section with link URLs at the end of the document.  
	Press Ctrl+P to check it out in Chrome print preview.


Credits
-------------

The people, pages, and projects that made this extension possible. In no particular order. 

1. John Gruber - the farther of the [markdown](http://daringfireball.net/projects/markdown/)
2. John Fraser, Dana Robinson, and Stack Exchange - the authors of the [pagedown](http://code.google.com/p/pagedown/) project
3. [jQuery](http://jquery.com/) - the turning point in web development
4. [GoSquared](http://www.gosquared.com/liquidicity/archives/70) - free and commercial icons resource.
5. Google - for making Chrome. ;)