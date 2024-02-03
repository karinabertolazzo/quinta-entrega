import Link from 'next/link'
import styles from './card.module.css'

export default async function Card() {
	const cards = await fetch('http://localhost:5188/api/Projeto').then((res) =>
		res.json(),
	)
	console.log(cards)

	return ( 
		
		<div className='container bg-light mb-5'>
			{cards?.map((card) => (


<div className='col mx-auto mb-5'  key={card.idDestino} style={{ width: "30rem" }} >
<div className="card mt-5">
 <img src={card.foto} alt={card.nomeDestino} className="card-img-top"/>
  <div className="card-body">
    <h5 className="card-title">{card.nomeDestino}</h5>
    <p style={{ fontSize: "small", fontStyle: "italic" }} className="card-text">
	{card.descricao}
    </p>
    <p className="card-text">
	<p>Valor {card.valorDestino}</p>
      <small className="text-body-secondary">Valor Promocional:</small>
    </p>
    <p>{card.valorPromocionalDestino}</p>
    <p> Promoção:{card.promocoesDestino}</p>

</div>
  </div>
</div>





  




					


					
				
			))}
		</div>
	)
}
