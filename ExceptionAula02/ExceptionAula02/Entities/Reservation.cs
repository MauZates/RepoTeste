using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionAula02.Entities
{
    /// <summary>
    /// Classe Reserva
    /// </summary>
    class Reservation
    {
        /// <summary>
        /// Número do quarto
        /// </summary>
        public int RoomNumber { get; set; }
        /// <summary>
        /// Dia da Entrada
        /// </summary>
        public DateTime CheckIn { get; set; }
        /// <summary>
        /// Dia da Saida
        /// </summary>
        public DateTime CheckOut { get; set; }

        /// <summary>
        /// Construtor padrao
        /// </summary>
        public Reservation()
        {

        }
        /// <summary>
        /// Construtor com os 3 argumentos
        /// </summary>
        /// <param name="roomNumber"> Numero do quarto</param>
        /// <param name="checkIn"> Dia da entrada</param>
        /// <param name="checkOut"> Dia da saida</param>
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        /// <summary>
        /// Método que pega a data da entrada informada, subtrai com a data de saida
        /// e retorna os dias
        /// </summary>
        /// <returns>Retorna o total de dias entre o checkin e checkout</returns>
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        /// <summary>
        /// Atualiza os dados de entrada e saida com as novas datas informadas
        /// </summary>
        /// <param name="checkIn">Nova data de entrada</param>
        /// <param name="checkOut">Nova data de saida</param>
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update mus be future dates";
            }
            else if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date mmust be after check-in date";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }

        /// <summary>
        /// Formata a frase de retorno
        /// </summary>
        /// <returns>Retorna a frase formatada, com a informação de checkin
        /// checkout e quandos dias de intervalo entre os dois</returns>
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
