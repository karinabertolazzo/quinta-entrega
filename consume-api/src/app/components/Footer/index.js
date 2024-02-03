export default function Footer() {
	return (
		<footer className="bg-dark text-light py-5 text-center">
  <div className="container text-center">
    <div className="row text-center">
      <div className="col mx-auto">
        <h5>Contato</h5>
        <address>
          <p>
            <i className="fas fa-map-marker-alt" /> Rua Bertolazzo, 1234
          </p>
          <p>
            <i className="fas fa-phone" /> (21) 3333-3333
          </p>
          <p>
            <i className="fas fa-envelope" /> bertolazzoilhas@viagens.com
          </p>
        </address>
      </div>
    </div>
    <hr />
    <div className="text-center">
      <p>© 2023 Agência de Viagens</p>
      <div className="social-icons">
        <a href="#" className="text-light">
          <i className="fab fa-facebook" />
        </a>
        <a href="#" className="text-light">
          <i className="fab fa-twitter" />
        </a>
        <a href="#" className="text-light">
          <i className="fab fa-instagram" />
        </a>
      </div>
    </div>
  </div>
</footer>

	)
}