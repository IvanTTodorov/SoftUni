function getArticleGenerator(articles) {

   return () => {
    while (articles.length > 0) {
        let showedArticle = document.getElementById('content');   
        let article = document.createElement('article'); 
        let currText = articles.shift(); 
        article.textContent = currText; 
        showedArticle.appendChild(article); 

        return showedArticle; 

    }
   }

}
