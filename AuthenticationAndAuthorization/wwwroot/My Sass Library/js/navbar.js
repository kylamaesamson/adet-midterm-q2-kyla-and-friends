const hamburger = document.querySelector(".hamburger");
const navLinks = document.querySelector(".nav-links");
const links = document.querySelectorAll(".nav-links links");
const shadowOverlay = document.querySelector(".shadow-overlay");



hamburger.addEventListener("click", () => {
    navLinks.classList.toggle("open");
    shadowOverlay.classList.toggle("active");
});

const header = document.querySelector(".header");
const sectionOne = document.querySelector(".scroll-check");

const sectionOneOptions = {
    rootMargin: "-220px 0px 0px 0px"
};

const sectionOneObserver = new IntersectionObserver(function(entries, sectionOneObserver)
{
    entries.forEach(entry => {
        console.log(entry.target);
        if(!entry.isIntersecting){
            header.classList.add("scrolled");
        }else{
            header.classList.remove("scrolled");
        }
    })
},sectionOneOptions);

sectionOneObserver.observe(sectionOne);


const checkboxPc = document.getElementById("nightToggle");
const checkboxMobile = document.getElementById("nightToggleMobile");

if(checkboxPc){
    initTheme();
}

function initTheme() {
    var darkThemeSelected = (localStorage.getItem('nightToggle') !== null && localStorage.getItem('nightToggle') === 'night');
    checkboxPc.checked = darkThemeSelected;
    checkboxMobile.checked = darkThemeSelected;
    darkThemeSelected ? document.body.setAttribute('data-theme', 'night') : document.body.removeAttribute('data-theme');
};


checkboxPc.addEventListener('change', function(){
    if(this.checked){
        trans();
        document.body.setAttribute('data-theme', 'night');
        localStorage.setItem('nightToggle', 'night');
        checkboxMobile.checked = true;
    }else
    {
        trans();
        document.body.setAttribute('data-theme', 'light');
        localStorage.removeItem('nightToggle')
        checkboxMobile.checked = false;
    }
});

checkboxMobile.addEventListener('change', function(){
    if(this.checked){
        trans();
        document.body.setAttribute('data-theme', 'night');
        localStorage.setItem('nightToggle', 'night');
        checkboxPc.checked = true;
    }else
    {
        trans();
        document.body.setAttribute('data-theme', 'light');
        localStorage.removeItem('nightToggle')
        checkboxPc.checked = false;
    }
});

const trans = () => {
    document.body.classList.add('transition');
    window.setTimeout(() => {
        document.body.classList.remove('transition')
    }, 400)
}




