using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    internal class CreditCalculator
    {
        private readonly Repository repository = new Repository();

        public async Task<CreditInfo> Calculate()
        {


            Task<int> getClientId = repository.GetClientId();
            Task<string> getFullname = repository.GetFullName(await getClientId);
            Task<long> getCreditId = repository.GetCreditId(await getClientId);

            Task<DateTime> dateOfCredit = repository.GetDateOfCredit(await getCreditId);
            Task<int> creditAmount = repository.GetCreditAmount(await getCreditId);
            Task<int> monthlyRate = repository.GetMonthlyRate(await getCreditId);
            Task<int> monthlyPayment = repository.GetMonthlyPayment(await getCreditId);
            Task<int> creditTerm = repository.GetCreditTerm(await getCreditId);

            // Вычисляем количество месяцев с получения кредита
            int months = 12 * (DateTime.Now.Year - dateOfCredit.Year) + DateTime.Now.Month - dateOfCredit.Month;

            // Вычисляем уже выплаченную сумму
            int paidAmount = months * monthlyPayment;

            // Вычисляем общую сумму платежа по процентам
            double interestCharges = creditAmount * monthlyRate / 100 * creditTerm;

            return new CreditInfo
            {
                FullName = $"{fullname}",
                PaidAmount = paidAmount,
                LeftToPay = creditAmount + interestCharges - paidAmount
            };
        }
    }
}
