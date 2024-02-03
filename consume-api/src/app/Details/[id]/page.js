import styles from './card.module.css'

export default async function Details({ params }) {
	console.log("esse e o id enviado: ", params.id)

	const card = await fetch(`http://localhost:7777/api/Game/${params.id}`).then((res) =>
		res.json(),
	)


	return (
		<div className={styles.container}>
			<div className={styles.card}>
				<img src={card.gameURL} alt={card.title} />
				<div className={styles.card_title}>
					<p>{card.name}</p>
				</div>
			</div>
		</div>
	)
}
