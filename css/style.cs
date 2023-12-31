#body {
  background-color: lightpink;
  font-family: "Times New Roman", Times, serif;
}

.card {
  width: 300px;
  margin-top: 100px;
  margin-bottom: 100px;
  display: flex;
  cursor: pointer;
}

#carouselExampleCaptions {
  width: 80rem;
  margin-left: 120px;
  margin-right: 30px;
  margin-top: 100px;
}

#mediosdepago {
  background-color: black;
  font-size: 100px;
  text-align: center;
  list-style-type: none;
  color: rgb(99, 8, 67);
}
#mediosdepago ul li {
  font-size: 60px;
  text-align: center;
  list-style-type: none;
  color: rgb(99, 8, 67);
}

#redes h1 {
  font-family: "Times New Roman", Times, serif;
  font-size: 50px;
  text-align: center;
  color: rgb(99, 8, 67);
  margin-top: 50px;
}

.container-boton a {
  font-size: 50px;
  text-align: center;
  color: lightpink;
  background-color: rgb(99, 8, 67);
  margin-left: 650px;
  margin-right: 600px;
  margin-top: 50px;
  margin-bottom: 50px;
  text-decoration: none;
  border-radius: 15px;
  padding: 30px;
  grid-area: boton;
  display: flex;
}

#peinadosservicio1 {
  text-align: center;
  color: rgb(99, 8, 67);
  font-size: 60px;
  margin-top: 100px;
  margin-bottom: 100px;
}

#peinadosservicio {
  font-size: 40px;
  margin-top: 30px;
  margin-bottom: 30px;
  margin-left: 70px;
}
#peinadosservicio ul {
  text-align: center;
  list-style-type: none;
  margin-bottom: 100px;
  color: rgb(99, 8, 67);
  font-size: 40px;
  text-align: center;
  list-style-type: none;
}

#animacionservicio ul {
  text-align: center;
  list-style-type: none;
  margin-bottom: 50px;
  color: rgb(99, 8, 67);
  font-size: 60px;
  margin-top: 80px;
  margin-bottom: 100px;
}

#imgcolor {
  margin-right: 500px;
  margin-left: 100px;
}

#iniciocatalogo {
  text-align: center;
}

.d-flex {
  margin-left: 250px;
  margin-right: 120px;
  margin-top: 100px;
  margin-bottom: 50px;
}

#nosotrostitulo {
  font-size: 60px;
  text-align: center;
  color: rgb(99, 8, 67);
  font-family: "Times New Roman", Times, serif;
  margin-top: 80px;
}

#nosotrospresentacion {
  font-size: 40px;
  text-align: center;
}

#nosotrosfotos {
  text-align: center;
  justify-content: space-around;
  display: flex;
}

header {
  background-color: rgb(99, 8, 67);
  border-bottom: 3px solid black;
  border-top: 3px solid black;
  border-left: 3px solid black;
  border-right: 3px solid black;
}
header #logo {
  width: 100px;
  height: 100px;
  display: flex;
}
header nav ul {
  list-style-type: none;
  display: flex;
  align-items: center;
  justify-content: space-around;
}
header nav ul li {
  margin: 15px;
}
header nav ul li a {
  text-decoration: none;
  color: lightpink;
  font-size: 3rem;
  display: flex;
}

#derechos {
  font-size: 20px;
  text-align: center;
  background-color: rgb(99, 8, 67);
  margin-top: 50px;
  margin-bottom: 0;
}

#navhover:hover {
  background-color: black;
  border-radius: 300px;
  transform: rotate(20deg);
}

#navhover {
  cursor: pointer;
  transition: all 1s;
  cursor: pointer;
}

#logowhats {
  width: 100px;
  margin-left: 1400px;
  transition: all 1s;
  position: fixed;
  bottom: 0px;
}

#logowhats:hover {
  border-radius: 300px;
  transform: rotate(360deg);
}

#cardcatalogo {
  transition: all 1s;
}

#cardcatalogo:hover {
  transform: translatey(60px);
}

@media (max-width: 600px) {
  #header {
    background-color: 1px solid black;
    border-bottom: 1px solid black;
    border-top: 1px solid black;
    border-left: 1px solid black;
    border-right: 1px solid black;
  }
  #header #logo {
    width: 20px;
    height: 20px;
  }
  #header nav ul {
    list-style-type: none;
    display: flex;
    align-items: center;
    justify-content: space-around;
  }
  #header nav ul li {
    margin: 2px;
  }
  #header nav ul li a {
    text-decoration: none;
    color: lightpink;
    font-size: 10px;
    display: flex;
  }
}
@media (max-width: 600px) {
  #carouselExampleCaptions {
    width: 300px;
    margin-top: 70px;
    margin-bottom: 1px;
    margin-left: 35px;
    display: flex;
  }
}
@media (max-width: 600px) {
  #card {
    width: 5px;
    margin-left: 35px;
  }
}
@media (max-width: 600px) {
  #mediosdepago2 {
    font-size: 50px;
  }
}
@media (max-width: 600px) {
  .card2 {
    width: 100px;
    margin-top: 40px;
  }
}
@media (max-width: 600px) {
  #contacto {
    font-size: 20px;
    margin-left: 40px;
    margin-right: 40px;
    text-align: center;
  }
}
@media (max-width: 600px) {
  #redes {
    font-size: 20px;
  }
}
@media (max-width: 600px) {
  #buscar {
    width: 100px;
    margin-top: 10px;
    margin-left: 50px;
  }
}
@media (max-width: 600px) {
  .card {
    width: 80px;
    margin-top: 10px;
  }
}
@media (max-width: 600px) {
  #tituloservic {
    font-size: 20px;
  }
}
@media (max-width: 600px) {
  #evento {
    font-size: 20px;
  }
}
@media (max-width: 600px) {
  .card-text {
    font-size: 10px;
  }
}
@media (max-width: 600px) {
  #coment {
    width: 350px;
  }
}
@media (max-width: 768px) {
  #header {
    background-color: 3px solid black;
    border-bottom: 3px solid black;
    border-top: 3px solid black;
    border-left: 3px solid black;
    border-right: 3px solid black;
  }
  #header #logo {
    width: 50px;
    height: 40px;
  }
  #header nav ul {
    list-style-type: none;
    display: flex;
    align-items: center;
    justify-content: space-around;
  }
  #header nav ul li {
    margin: 4px;
  }
  #header nav ul li a {
    text-decoration: none;
    color: lightpink;
    font-size: 30px;
    display: flex;
  }
}
@media (max-width: 768px) {
  #carouselExampleCaptions {
    width: 600px;
    margin-top: 70px;
    margin-bottom: 1px;
    margin-left: 75px;
    display: flex;
  }
}
@media (max-width: 768px) {
  #mediosdepago2 {
    font-size: 1000px;
  }
}
@media (max-width: 768px) {
  #video1 {
    width: 150px;
    margin-top: 100px;
    display: flex;
  }
}
@media (max-width: 768px) {
  #contacto {
    font-size: 20px;
    margin-left: 40px;
    margin-right: 40px;
    text-align: center;
  }
}
@media (max-width: 768px) {
  #redes {
    font-size: 20px;
  }
}
@media (max-width: 768px) {
  #buscar {
    width: 100px;
    margin-top: 10px;
    margin-left: 50px;
  }
}
@media (max-width: 768px) {
  .card {
    width: 80px;
    margin-top: 10px;
  }
}
@media (max-width: 768px) {
  #tituloservic {
    font-size: 20px;
  }
}
@media (max-width: 768px) {
  #evento {
    font-size: 20px;
  }
}
@media (max-width: 768px) {
  .card-text {
    font-size: 10px;
  }
}
@media (max-width: 768px) {
  #coment {
    width: 350px;
  }
}

/*# sourceMappingURL=style.cs.map */
