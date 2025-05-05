using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FireArmsInventoryManagementSystem.Data;
using FireArmsInventoryManagementSystem.Models;

namespace FireArmsInventoryManagementSystem.Controllers
{
    public class Form4473Controller : Controller
    {
        private readonly FirearmsInventoryDB _context;

        public Form4473Controller(FirearmsInventoryDB context)
        {
            _context = context;
        }

        // GET: Form4473
        public async Task<IActionResult> Index()
        {
            return View(await _context.Form4473Records.ToListAsync());
        }

        // GET: Form4473/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form4473Record = await _context.Form4473Records
                .FirstOrDefaultAsync(m => m.Id == id);
            if (form4473Record == null)
            {
                return NotFound();
            }

            return View(form4473Record);
        }

        // GET: Form4473/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Form4473/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TransferorsTransactionNumber,TotalNumberOfFirearms,IsPawnRedemption,PawnRedemptionLineNumbers,IsPrivatePartyTransfer,TransfereeLastName,TransfereeFirstName,TransfereeMiddleName,TransfereeStreetAddress,TransfereeCity,TransfereeCountyParishBorough,TransfereeState,TransfereeZipCode,ResideInCityLimits,TransfereePlaceOfBirth,HeightFeet,HeightInches,Weight,Sex,DateOfBirth,SSN,UpinOrAmdId,IsHispanicOrLatino,RaceAmericanIndianOrAlaskaNative,RaceAsian,RaceBlackOrAfricanAmerican,RaceNativeHawaiianOrPacificIslander,RaceWhite,CountryOfCitizenship,AlienNumberOrAdmissionNumber,IsActualTransfereeBuyer,WillDisposeToFelony,UnderIndictment,EverConvictedFelony,FugitiveFromJustice,UnlawfulUserOfControlledSubstance,AdjudicatedMentallyDefective,DishonorableDischarge,SubjectToRestrainingOrder,ConvictedMisdemeanorDomesticViolence,RenouncedUSCitizenship,AlienIllegally,NonImmigrantVisa,NonImmigrantVisaException,WillDisposeToProhibitedPerson,TransfereeSignature,CertificationDate,CategoryHandgun,CategoryLongGun,CategoryOther,GunShowOrEventName,GunShowOrEventCityStateZip,IdentificationType,IdentificationNumber,IdentificationExpDate,SupplementalGovtDoc,PcsBaseName,PcsEffectiveDate,PcsOrderNumber,NonImmigrantExceptionDocumentation,NicsCheckInitiatedDate,NicsOrStateTransactionNumber,InitialNicsResponse,NicsDelayedEligibleDate,SubsequentNicsResponses,PostTransferNicsResponse,NicsProceedDate,NicsDeniedDate,NicsCancelledDate,NicsOverturnedDate,IsNfaBackgroundCheckAlready,IsStatePermitExemption,StatePermitType,StatePermitIssueDate,StatePermitExpirationDate,StatePermitNumber,TransfereeRecertSignature,TransfereeRecertDate,LicenseeUseRemarks,SellerTradeName,SellerStreetAddress,SellerCityStateZip,SellerFFLNumber,TransferorName,TransferorSignature,TransferDate")] Form4473Record form4473Record)
        {
            if (ModelState.IsValid)
            {
                form4473Record.Id = Guid.NewGuid();
                _context.Add(form4473Record);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(form4473Record);
        }

        // GET: Form4473/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form4473Record = await _context.Form4473Records.FindAsync(id);
            if (form4473Record == null)
            {
                return NotFound();
            }
            return View(form4473Record);
        }

        // POST: Form4473/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,TransferorsTransactionNumber,TotalNumberOfFirearms,IsPawnRedemption,PawnRedemptionLineNumbers,IsPrivatePartyTransfer,TransfereeLastName,TransfereeFirstName,TransfereeMiddleName,TransfereeStreetAddress,TransfereeCity,TransfereeCountyParishBorough,TransfereeState,TransfereeZipCode,ResideInCityLimits,TransfereePlaceOfBirth,HeightFeet,HeightInches,Weight,Sex,DateOfBirth,SSN,UpinOrAmdId,IsHispanicOrLatino,RaceAmericanIndianOrAlaskaNative,RaceAsian,RaceBlackOrAfricanAmerican,RaceNativeHawaiianOrPacificIslander,RaceWhite,CountryOfCitizenship,AlienNumberOrAdmissionNumber,IsActualTransfereeBuyer,WillDisposeToFelony,UnderIndictment,EverConvictedFelony,FugitiveFromJustice,UnlawfulUserOfControlledSubstance,AdjudicatedMentallyDefective,DishonorableDischarge,SubjectToRestrainingOrder,ConvictedMisdemeanorDomesticViolence,RenouncedUSCitizenship,AlienIllegally,NonImmigrantVisa,NonImmigrantVisaException,WillDisposeToProhibitedPerson,TransfereeSignature,CertificationDate,CategoryHandgun,CategoryLongGun,CategoryOther,GunShowOrEventName,GunShowOrEventCityStateZip,IdentificationType,IdentificationNumber,IdentificationExpDate,SupplementalGovtDoc,PcsBaseName,PcsEffectiveDate,PcsOrderNumber,NonImmigrantExceptionDocumentation,NicsCheckInitiatedDate,NicsOrStateTransactionNumber,InitialNicsResponse,NicsDelayedEligibleDate,SubsequentNicsResponses,PostTransferNicsResponse,NicsProceedDate,NicsDeniedDate,NicsCancelledDate,NicsOverturnedDate,IsNfaBackgroundCheckAlready,IsStatePermitExemption,StatePermitType,StatePermitIssueDate,StatePermitExpirationDate,StatePermitNumber,TransfereeRecertSignature,TransfereeRecertDate,LicenseeUseRemarks,SellerTradeName,SellerStreetAddress,SellerCityStateZip,SellerFFLNumber,TransferorName,TransferorSignature,TransferDate")] Form4473Record form4473Record)
        {
            if (id != form4473Record.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(form4473Record);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Form4473RecordExists(form4473Record.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(form4473Record);
        }

        // GET: Form4473/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var form4473Record = await _context.Form4473Records
                .FirstOrDefaultAsync(m => m.Id == id);
            if (form4473Record == null)
            {
                return NotFound();
            }

            return View(form4473Record);
        }

        // POST: Form4473/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var form4473Record = await _context.Form4473Records.FindAsync(id);
            if (form4473Record != null)
            {
                _context.Form4473Records.Remove(form4473Record);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Form4473RecordExists(Guid id)
        {
            return _context.Form4473Records.Any(e => e.Id == id);
        }
    }
}
