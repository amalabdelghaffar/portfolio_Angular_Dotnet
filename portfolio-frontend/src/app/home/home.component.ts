import { Component, OnInit, OnDestroy, AfterViewInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import {
    PortfolioService, Profile, Experience, Education,
    Skill, Certification, Language, CommunityActivity
} from '../services/portfolio.service';

@Component({
    selector: 'app-home',
    standalone: true,
    imports: [CommonModule, FormsModule],
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit, OnDestroy, AfterViewInit {
    profile: Profile | null = null;
    experiences: Experience[] = [];
    educations: Education[] = [];
    skills: Skill[] = [];
    filteredSkills: Skill[] = [];
    skillCategories: string[] = [];
    activeCategory = 'All';
    certifications: Certification[] = [];
    languages: Language[] = [];
    community: CommunityActivity[] = [];

    contactForm = { name: '', email: '', message: '' };
    activeSection = 'hero';
    scrollListener: any;
    menuOpen = false;
    showScrollTop = false;
    isLoading = true;
    private observer: IntersectionObserver | null = null;

    constructor(private portfolioService: PortfolioService) { }

    ngOnInit() {
        this.loadData();
        this.setupScrollSpy();
    }

    ngAfterViewInit() {
        this.setupIntersectionObserver();
    }

    ngOnDestroy() {
        window.removeEventListener('scroll', this.scrollListener);
        if (this.observer) this.observer.disconnect();
    }

    loadData() {
        let loaded = 0;
        const total = 7;
        const check = () => {
            loaded++;
            if (loaded >= total) {
                this.isLoading = false;
                // Re-observe after data renders (one tick delay for Angular to render *ngFor)
                setTimeout(() => this.setupIntersectionObserver(), 100);
            }
        };

        this.portfolioService.getProfile().subscribe({ next: p => { this.profile = p; check(); }, error: check });
        this.portfolioService.getExperiences().subscribe({ next: e => { this.experiences = e; check(); }, error: check });
        this.portfolioService.getEducations().subscribe({ next: e => { this.educations = e; check(); }, error: check });
        this.portfolioService.getSkills().subscribe({
            next: s => {
                this.skills = s;
                this.filteredSkills = s;
                const cats = [...new Set(s.map(sk => sk.category))];
                this.skillCategories = ['All', ...cats];
                check();
            }, error: check
        });
        this.portfolioService.getCertifications().subscribe({ next: c => { this.certifications = c; check(); }, error: check });
        this.portfolioService.getLanguages().subscribe({ next: l => { this.languages = l; check(); }, error: check });
        this.portfolioService.getCommunity().subscribe({ next: c => { this.community = c; check(); }, error: check });
    }

    filterSkills(category: string) {
        this.activeCategory = category;
        this.filteredSkills = category === 'All' ? this.skills : this.skills.filter(s => s.category === category);
    }

    scrollTo(sectionId: string) {
        this.menuOpen = false;
        const el = document.getElementById(sectionId);
        if (el) el.scrollIntoView({ behavior: 'smooth', block: 'start' });
    }

    toggleMenu() {
        this.menuOpen = !this.menuOpen;
    }

    scrollToTop() {
        window.scrollTo({ top: 0, behavior: 'smooth' });
    }

    setupScrollSpy() {
        const sections = ['hero', 'about', 'experience', 'education', 'skills', 'certifications', 'community', 'contact'];
        this.scrollListener = () => {
            const scrollY = window.scrollY + 100;
            this.showScrollTop = window.scrollY > 400;
            for (const id of sections) {
                const el = document.getElementById(id);
                if (el && el.offsetTop <= scrollY && el.offsetTop + el.offsetHeight > scrollY) {
                    this.activeSection = id;
                }
            }
        };
        window.addEventListener('scroll', this.scrollListener, { passive: true });
    }

    setupIntersectionObserver() {
        if (this.observer) this.observer.disconnect();
        this.observer = new IntersectionObserver(
            (entries) => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('visible');
                        this.observer?.unobserve(entry.target);
                    }
                });
            },
            { threshold: 0.08 }
        );
        document.querySelectorAll('.reveal').forEach(el => this.observer!.observe(el));
    }

    getSkillBarWidth(level: number): string { return level + '%'; }
    getLangPct(level: number): string { return (level * 3.6) + 'deg'; }

    getTechTags(technologies: string): string[] {
        return technologies.split(',').map(t => t.trim()).filter(t => t);
    }

    sendMessage() {
        alert(`Merci ${this.contactForm.name}! Votre message a été envoyé.`);
        this.contactForm = { name: '', email: '', message: '' };
    }

    get yearsExperience(): number {
        return new Date().getFullYear() - 2023;
    }

    get currentYear(): number {
        return new Date().getFullYear();
    }
}
