import Link from 'next/link'

export default function Header() {
	return (
		<nav className="navbar bg-primary border-body" data-bs-theme="dark">
 <header className="header">
 <div className="d-flex"> <p className="text-white fs-1">
  Bertolazzo </p> <span className="text-dark fw-bolder fs-1"> Ilhas </span></div>

			<ul>
				<li>
					<Link href="/RotaUm">Destinos</Link>
				</li>
				
			</ul>
		</header>
</nav>

		
	)
}